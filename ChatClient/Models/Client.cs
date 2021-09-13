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
    public string CurrentRoomname;
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

      // Message handlers
      connection.On<String, String>("ReceiveMessage", (user, message) =>
      {
        ClientControl.Update(user, message);
      });

      connection.Closed += (err) =>
      {
        ClientControl.Update(null, null, true);
        return Task.CompletedTask;
      };

      Username = username;
    }
  }
}
