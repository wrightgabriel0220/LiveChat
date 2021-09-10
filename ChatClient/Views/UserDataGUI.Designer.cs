
namespace ChatClient
{
  partial class UserDataGUI
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.ConnectButton = new System.Windows.Forms.Button();
      this.UsernameInputLabel = new System.Windows.Forms.Label();
      this.IPInputLabel = new System.Windows.Forms.Label();
      this.UsernameInput = new System.Windows.Forms.TextBox();
      this.IPInput = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // ConnectButton
      // 
      this.ConnectButton.Location = new System.Drawing.Point(12, 65);
      this.ConnectButton.Name = "ConnectButton";
      this.ConnectButton.Size = new System.Drawing.Size(269, 23);
      this.ConnectButton.TabIndex = 0;
      this.ConnectButton.Text = "Connect";
      this.ConnectButton.UseVisualStyleBackColor = true;
      this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
      // 
      // UsernameInputLabel
      // 
      this.UsernameInputLabel.AutoSize = true;
      this.UsernameInputLabel.Location = new System.Drawing.Point(9, 16);
      this.UsernameInputLabel.Name = "UsernameInputLabel";
      this.UsernameInputLabel.Size = new System.Drawing.Size(58, 13);
      this.UsernameInputLabel.TabIndex = 1;
      this.UsernameInputLabel.Text = "Username:";
      // 
      // IPInputLabel
      // 
      this.IPInputLabel.AutoSize = true;
      this.IPInputLabel.Location = new System.Drawing.Point(47, 42);
      this.IPInputLabel.Name = "IPInputLabel";
      this.IPInputLabel.Size = new System.Drawing.Size(20, 13);
      this.IPInputLabel.TabIndex = 2;
      this.IPInputLabel.Text = "IP:";
      // 
      // UsernameInput
      // 
      this.UsernameInput.Location = new System.Drawing.Point(73, 13);
      this.UsernameInput.Name = "UsernameInput";
      this.UsernameInput.Size = new System.Drawing.Size(208, 20);
      this.UsernameInput.TabIndex = 3;
      // 
      // IPInput
      // 
      this.IPInput.Location = new System.Drawing.Point(73, 39);
      this.IPInput.Name = "IPInput";
      this.IPInput.Size = new System.Drawing.Size(208, 20);
      this.IPInput.TabIndex = 4;
      // 
      // UserDataGUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(293, 98);
      this.Controls.Add(this.IPInput);
      this.Controls.Add(this.UsernameInput);
      this.Controls.Add(this.IPInputLabel);
      this.Controls.Add(this.UsernameInputLabel);
      this.Controls.Add(this.ConnectButton);
      this.Name = "UserDataGUI";
      this.Text = "GabeChat Client";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ConnectButton;
    private System.Windows.Forms.Label UsernameInputLabel;
    private System.Windows.Forms.Label IPInputLabel;
    private System.Windows.Forms.TextBox UsernameInput;
    private System.Windows.Forms.TextBox IPInput;
  }
}