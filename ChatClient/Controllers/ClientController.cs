using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.SignalR.Client;
using System.Net.Http;
using ChatClient.Models;
using System.Drawing;

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

    public void ReportError(Exception err, string AttemptedOperationTitle, string ClientMessage)
    {
      _ClientGUI.LogMessage(Color.Red, ClientMessage);
      Console.WriteLine($"ERROR:\n Operation: {AttemptedOperationTitle} \n Exception: {err.Message} - {err.InnerException}");
    }

    public async Task EstablishConnection(ChatClientGUI ClientGUI, string ip, string username)
    {
      _client = new Client(this, ip, username);
      _ClientGUI.LogMessage(Color.Blue, "Attempting to connect...");
      try
      {
        await _client.connection.StartAsync();
        await JoinRoom("General");
      }
      catch (Exception err)
      {
        _client = null;
        ReportError(err, "EstablishConnection", "Failed to establish connection. Check your target IP or try again.");
      }
      Update(null, null, true);
    }

    public async Task JoinRoom(string roomname)
    {
      try
      {
        if (_client != null) await _client.connection.InvokeAsync("JoinRoom", _client.Username, roomname);
      }
      catch (Exception err) {
        ReportError(err, "JoinRoom", "Failed to join room. Check your connection and try again.");
      }
    }

    public string GetCurrentRoomname()
    {
      if (_client != null) return _client.CurrentRoomname;
      return "";
    }

    public void Update(string user, string message, bool connectionStateIsChanging = false)
    {
      if (user != null && message != null) _ClientGUI.RenderMessage(user, message);
      if (user == null) _ClientGUI.LogMessage(Color.Blue, message);
      if (connectionStateIsChanging) _ClientGUI.UpdateGUIForConnectionState(GetConnectedState());
    }

    public bool GetConnectedState()
    {
      if (_client != null) return _client.connection.State.ToString() == "Connected";
      return false;
    }

    public async Task SendMessage(string message, string targetRoom)
    {
      await _client.connection.InvokeAsync("SendMessage", _client.Username, message, targetRoom);
    }
  }
}
