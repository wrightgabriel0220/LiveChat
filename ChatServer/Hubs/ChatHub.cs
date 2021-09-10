using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using ChatServer;
using ChatServer.Models;

namespace ChatServer.Hubs
{
  public interface IChatClient
  {
    Task RenderMessage(Message message);
  }

  public class ChatHub : Hub
  {
    private IRoomRepository _repository;
    private readonly Random _random;
    public ChatHub(IRoomRepository repository, Random random)
    {
      _repository = repository;
      _random = random;
    }

    public Task SendMessage(string user, string message)
    {
      return Clients.All.SendAsync("ReceiveMessage", user, message);
    }

    public void AddUser(string Name, Room TargetRoom)
    {
      TargetRoom.ActiveUsers.Add(Name, new User(Name));
    }

    public override async Task OnConnectedAsync()
    {
      // When the user's client connects to the server
      // Create a user and connect them to general chat
      // var room = _repository.Rooms.FirstOrDefault(room => room.Name == "General");
      Console.WriteLine("Getting a connection at ChatHub");
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
