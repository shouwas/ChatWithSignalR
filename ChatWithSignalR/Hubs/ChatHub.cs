using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatWithSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string formUser, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", formUser, message);
        }
    }
}
