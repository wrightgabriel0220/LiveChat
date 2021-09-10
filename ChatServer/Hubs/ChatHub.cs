using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using ChatServer;
using ChatServer.Models;

namespace ChatServer.Hubs
{
  public class ChatHub : Hub
  {
    //private RoomRepository _repository;
    //private readonly Random _random;
    public ChatHub()
    {
      // _repository = repository;
      // _random = random;
    }

    public Task SendMessage(string user, string message)
    {
      return Clients.All.SendAsync("ReceiveMessage", user, message);
    }

    public override async Task OnConnectedAsync()
    {
      // When the user's client connects to the server
      // Create a user and connect them to general chat
      // var room = _repository.Rooms.FirstOrDefault(room => room.Name == "General");
      Console.WriteLine("YOU DID IT! CONNECTED TO CHATHUB!");
      await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception error)
    {
      await base.OnDisconnectedAsync(error);
      Console.WriteLine(error);
      Console.WriteLine("Closing a connection at ChatHub");
    }
  }
}
