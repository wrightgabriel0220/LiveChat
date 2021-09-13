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
      // _repository = new RoomRepository(new List<Room>() { new Room("General") });
      // _random = random;
    }

    public Task SendMessage(string user, string message, string roomname)
    {
      return Clients.Group(roomname).SendAsync("ReceiveMessage", user, message);
    }

    public async Task<Task> JoinRoom(string username, string roomname)
    {
      Console.WriteLine($"{username} joined room {roomname}");
      await Groups.AddToGroupAsync(Context.ConnectionId, roomname);
      return Clients.Group(roomname).SendAsync("ReceiveMessage", null, $"{username} has joined {roomname}");
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
      Console.WriteLine($"Closing connection {Context.ConnectionId} at ChatHub");
    }
  }
}
