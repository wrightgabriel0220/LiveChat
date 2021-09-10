﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatServer.Models
{
  public class Message
  {
    public long Id { get; set; }
    public string Text { get; set; }
    public string Username { get; set; }
    public string Roomname { get; set; }
  }
}
