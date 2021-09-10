using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.SignalR.Client;

namespace ChatClient.Controllers
{
  class Client
  {
    public HubConnection connection;
    public Client(ChatClientGUI ClientGUI)
    {
      connection = new HubConnectionBuilder()
        .WithUrl("https://localhost:5001/chat")
        .Build();

      connection.On<String, String>("ReceiveMessage", (user, message) =>
      {
        ClientGUI.RenderMessage(user, message);
        return null;
      });

      Console.WriteLine($"connection state: {connection.State}");
    }
  }
}
