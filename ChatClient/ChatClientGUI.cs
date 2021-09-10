using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChatClient.Controllers;

namespace ChatClient
{
  public partial class ChatClientGUI : Form
  {
    private Client client;
    public ChatClientGUI()
    {
      InitializeComponent();
    }

    private async void ConnectButton_Click(object sender, EventArgs e)
    {
      Console.WriteLine("Attempting to connect");
      try
      {
        client = new Client();
        await client.connection.StartAsync();
        Console.WriteLine("Listening...");
      }
      catch (Exception err)
      {
        Console.WriteLine($"Connection to websocket server failed with error: {err.Message}");
      }
    }

    private void SendButton_Click(object sender, EventArgs e)
    {
      Console.WriteLine($"Sending message: {MsgInput.Text}");
      client.connection.SendCoreAsync("SendMessage", new string[] { MsgInput.Text });
      MsgInput.Text = "";
    }
  }
}
