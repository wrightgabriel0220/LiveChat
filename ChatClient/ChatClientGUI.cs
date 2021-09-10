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
    public ChatClientGUI()
    {
      InitializeComponent();
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
        client = new Client(this);
        await client.connection.StartAsync();
        Console.WriteLine("Listening...");
      }
      catch (Exception err)
      {
        Console.WriteLine($"Connection to websocket server failed with error: {err.Message}");
      }
    }

    private async void SendButton_Click(object sender, EventArgs e)
    {
      Console.WriteLine($"Sending message: {MsgInput.Text}");
      await client.connection.InvokeAsync("SendMessage", "slappyjoe", MsgInput.Text);
      MsgInput.Text = "";
    }
  }
}
