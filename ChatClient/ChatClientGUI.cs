using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChatClient.Controllers;
using Microsoft.AspNetCore.SignalR.Client;

namespace ChatClient
{
  public partial class ChatClientGUI : Form
  {
    private Client client;
    private string _ip;
    private string _username;
    public ChatClientGUI(string ip, string username)
    {
      InitializeComponent();
      _ip = ip;
      _username = username;
    }

    public void RenderMessage(string user, string message)
    {
      var messageString = $"{user}: {message}";
      MessageFeed.Text += "\n" + messageString;
    }

    private async void ConnectButton_Click(object sender, EventArgs e)
    {
      Console.WriteLine("Attempting to connect");
      try
      {
        client = new Client(this, _ip);
        await client.connection.StartAsync();
        Console.WriteLine("Listening...");
      }
      catch (Exception err)
      {
        Console.WriteLine($"Connection to websocket server failed with error: {err.Message}");
        Console.WriteLine($"InnerException: {err.InnerException}");
      }
    }

    private async void SendButton_Click(object sender, EventArgs e)
    {
      Console.WriteLine($"Sending message: {MsgInput.Text}");
      await client.connection.InvokeAsync("SendMessage", _username, MsgInput.Text);
      MsgInput.Text = "";
    }
  }
}
