using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ChatClient.Controllers;

namespace ChatClient.Models
{
  class Client
  {
    public HubConnection connection;
    public string Username;
    public Client(ClientController ClientControl, string ip, string username)
    {
      connection = new HubConnectionBuilder()
        .WithUrl($"https://{ip}:5001/chat", config =>
        {
          config.HttpMessageHandlerFactory = x => new HttpClientHandler()
          {
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator,
          };
        })
        .Build();

      void TriggerClientControlUpdate(string user, string message, bool IsChangingConnectionState)
      {
        ClientControl.Update(user, message, IsChangingConnectionState);
      }

      // Message handlers
      connection.On<String, String>("ReceiveMessage", (user, message) =>
      {
        ClientControl.Update(user, message);
      });

      connection.Closed += (err) =>
      {
        Console.WriteLine("test");
        TriggerClientControlUpdate(null, null, true);
        return Task.CompletedTask;
      };

      Username = username;
    }
  }
}
