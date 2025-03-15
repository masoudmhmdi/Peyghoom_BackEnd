
using Peyghoom_BackEnd.Hubs;
using System.Security.Cryptography;
using System.Text;

namespace Peyghoom_BackEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddSignalR(options =>
            {
                options.EnableDetailedErrors = true;
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            //app.UseAuthorization();

            //app.Use((context, next) =>
            //{
            //    HashAlgorithm sha256 = SHA256.Create();

            //    var byteArray = Encoding.ASCII.GetBytes("mamad.1415");
            //    var hash = sha256.ComputeHash(byteArray);
            //    var stringify  = hash.ToString();

            //    return next();
            //});




            app.MapHub<ChatHub>("chat-hub");

            app.Run();
        }
    }
}
