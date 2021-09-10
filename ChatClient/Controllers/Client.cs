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
    public Client()
    {
      connection = new HubConnectionBuilder()
        .WithUrl("https://localhost:5001/chat")
        .Build();

      connection.On<String>("ReceiveMessage", message =>
      {
        Console.WriteLine($"Somebody sent a message: {message}");
        return null;
      });

      Console.WriteLine($"connection state: {connection.State}");
    }
  }
}
