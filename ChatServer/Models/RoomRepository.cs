using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Models
{ 
  public interface IRoomRepository
  {
    List<Room> Rooms { get; }
  }

  public class RoomRepository : IRoomRepository
  {
    public List<Room> Rooms { get; } = new List<Room>();
  }
}
