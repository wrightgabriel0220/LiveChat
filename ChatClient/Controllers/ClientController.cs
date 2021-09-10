using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.SignalR.Client;
using System.Net.Http;
using ChatClient.Models;

namespace ChatClient.Controllers
{
  class ClientController
  {
    private Client _client = null;
    private readonly ChatClientGUI _ClientGUI;

    public ClientController(ChatClientGUI GUI)
    {
      _ClientGUI = GUI;
    }

    public async Task EstablishConnection(ChatClientGUI ClientGUI, string ip, string username)
    {
      _client = new Client(this, ip, username);
      Console.WriteLine("Attempting to connect");
      try
      {
        await _client.connection.StartAsync();
      }
      catch (Exception err)
      {
        _client = null;
        Console.WriteLine($"Connection to websocket server failed with error: {err.Message}");
        Console.WriteLine($"InnerException: {err.InnerException}");
      }
      Console.WriteLine("Connection Successful");
    }

    public void Update(string user, string message)
    {
      _ClientGUI.RenderMessage(user, message);
    }

    public bool GetConnectedState()
    {
      return _client.connection.State.ToString() == "Connected";
    }

    public async Task SendMessage(string message)
    {
      await _client.connection.InvokeAsync("SendMessage", _client.Username, message);
    }
  }
}
