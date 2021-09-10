using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatClient.Controllers;
using Microsoft.AspNetCore.SignalR.Client;

namespace ChatClient
{
  public partial class ChatClientGUI : Form
  {
    private readonly ClientController _client;
    private readonly string _ip;
    private readonly string _username;
    public ChatClientGUI(string ip, string username)
    {
      InitializeComponent();
      _client = new ClientController(this);
      _ip = ip;
      _username = username;
    }

    // View methods

    public void RenderMessage(string user, string message)
    {
      var messageString = $"{user}: {message}";
      MessageFeed.Text += "\n" + messageString;
    }

    // Controller Interactions

    private async void ConnectButton_Click(object sender, EventArgs e)
    {
      await _client.EstablishConnection(this, _ip, _username);
    }

    private async void SendButton_Click(object sender, EventArgs e)
    {
      await _client.SendMessage(MsgInput.Text);
    }
  }
}
