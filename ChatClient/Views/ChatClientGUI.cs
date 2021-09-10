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
      LogMessage($"{user}: {message}");
    }

    public void LogMessage(string message)
    {
      MessageFeed.SelectedText = "\n" + message;
    }

    // Controller Interactions

    private async void ConnectButton_Click(object sender, EventArgs e)
    {
      Console.WriteLine("Clicked the connect button!");
      await _client.EstablishConnection(this, _ip, _username);
    }

    private async void SendButton_Click(object sender, EventArgs e)
    {
      if (_client.GetConnectedState())
      {
        await _client.SendMessage(MsgInput.Text);
        MsgInput.Text = "";
      }
      else
      {
        MessageFeed.SelectionColor = Color.Red;
        LogMessage("Cannot send message without connection");
        MessageFeed.SelectionColor = Color.Black;
      }
    }

    private void ChatClientGUI_Load(object sender, EventArgs e)
    {
      ConnectButton.PerformClick();
    }
  }
}
