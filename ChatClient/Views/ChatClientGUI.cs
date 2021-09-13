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
    private readonly UserDataGUI _startupGUI;
    public ChatClientGUI(string ip, string username, UserDataGUI StartupGUI)
    {
      InitializeComponent();
      _client = new ClientController(this);
      _ip = ip;
      _username = username;
      _startupGUI = StartupGUI;
    }

    // View methods

    public void RenderMessage(string user, string message)
    {
      LogMessage(Color.Black, $"{user}: {message}");
    }

    public void LogMessage(Color color, string message)
    {
      MessageFeed.SelectionStart = MessageFeed.Text.Length > 0 ? MessageFeed.Text.Length - 1 : 0;
      MessageFeed.SelectionColor = color;
      MessageFeed.SelectedText = "\n" + message;
      MessageFeed.SelectionColor = Color.Black;
    }

    public void UpdateGUIForConnectionState(bool IsConnected)
    {
      if (ConnectButton.InvokeRequired || SendButton.InvokeRequired)
      {
        ConnectButton.Invoke(new Action<bool>(UpdateGUIForConnectionState), new object[] { IsConnected });
        return;
      }
      ConnectButton.Enabled = !IsConnected;
      SendButton.Enabled = IsConnected;
      if (IsConnected)
      {
        LogMessage(Color.Blue, "Connected to server!");
      }
      else
      {
        LogMessage(Color.Red, "Disconnected... Please press Connect to reattempt connection");
      }
    }

    // View-Controller Handlers

    private async void ConnectButton_Click(object sender, EventArgs e)
    {
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
        LogMessage(Color.Red, "Cannot send message without connection");
      }
    }

    private void ChatClientGUI_Load(object sender, EventArgs e)
    {
      ConnectButton.PerformClick();
    }

    private void ChatClientGUI_FormClosed(object sender, FormClosedEventArgs e)
    {
      _startupGUI.Close();
    }

    private void MsgInput_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendButton.PerformClick();
        e.Handled = true;
        e.SuppressKeyPress = true;
      }
    }
  }
}
