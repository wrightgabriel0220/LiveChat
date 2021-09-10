using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Models
{
  public class User
  {
    public User(string username)
    {
      Username = username;
    }

    public long Id { get; set; }
    public string Username { get; set; }
    public List<User> Friends { get; set; }
  }
}
