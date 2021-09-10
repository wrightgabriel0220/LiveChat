using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChatClient
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      // UserDataGUI UserData = new UserDataGUI();
      Application.Run(new UserDataGUI());
      // Application.Run(new ChatClientGUI(UserData.Ip, UserData.Username));
    }
  }
}
