using Microsoft.AspNetCore.SignalR;

namespace Peyghoom_BackEnd.Hubs
{
    public sealed class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            Console.WriteLine($"Client connected: {Context.ConnectionId}");
            await base.OnConnectedAsync();
        }
    }
}
