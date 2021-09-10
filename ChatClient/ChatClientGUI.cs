using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatClient
{
  public partial class ChatClientGUI : Form
  {
    public ChatClientGUI()
    {
      InitializeComponent();
    }

    private void ConnectButton_Click(object sender, EventArgs e)
    {
      Console.WriteLine("Attempting to connect");
    }

    private void SendButton_Click(object sender, EventArgs e)
    {
      Console.WriteLine($"Sending message: {MsgInput.Text}");
      MsgInput.Text = "";
    }
  }
}
