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

namespace ChatClient
{
  public partial class UserDataGUI : Form
  {
    public string Ip;
    public string Username;
    public UserDataGUI()
    {
      InitializeComponent();
    }



    private void ConnectButton_Click(object sender, EventArgs e)
    {
      new ChatClientGUI(IPInput.Text, UsernameInput.Text, this).Show();
      this.Hide();
    }
  }
}
