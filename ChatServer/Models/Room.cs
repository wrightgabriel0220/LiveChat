using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Models
{
  public class Room
  {
    public long Id { get; }
    public string Name { get; }
    public Hashtable ActiveUsers { get; }

    public Room(string name)
    {
      Name = name;
    }
  }
}
