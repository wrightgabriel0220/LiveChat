using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.SignalR.Client;
using System.Net.Http;

namespace ChatClient.Controllers
{
  class Client
  {
    public HubConnection connection;
    public Client(ChatClientGUI ClientGUI, string ip)
    {
      Console.WriteLine($"Iptest: {ip}");
      connection = new HubConnectionBuilder()
        .WithUrl($"https://{ip}:5001/chat", config =>
        {
          config.HttpMessageHandlerFactory = x => new HttpClientHandler()
          {
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator,
          };
        })
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
