
namespace ChatClient
{
    partial class ChatClientGUI
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
      this.SendButton = new System.Windows.Forms.Button();
      this.MsgInput = new System.Windows.Forms.TextBox();
      this.MessageFeed = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // ConnectButton
      // 
      this.ConnectButton.Location = new System.Drawing.Point(17, 415);
      this.ConnectButton.Name = "ConnectButton";
      this.ConnectButton.Size = new System.Drawing.Size(75, 23);
      this.ConnectButton.TabIndex = 0;
      this.ConnectButton.Text = "Connect";
      this.ConnectButton.UseVisualStyleBackColor = true;
      this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
      // 
      // SendButton
      // 
      this.SendButton.Location = new System.Drawing.Point(98, 415);
      this.SendButton.Name = "SendButton";
      this.SendButton.Size = new System.Drawing.Size(75, 23);
      this.SendButton.TabIndex = 3;
      this.SendButton.Text = "Send";
      this.SendButton.UseVisualStyleBackColor = true;
      this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
      // 
      // MsgInput
      // 
      this.MsgInput.Location = new System.Drawing.Point(17, 389);
      this.MsgInput.Name = "MsgInput";
      this.MsgInput.Size = new System.Drawing.Size(775, 20);
      this.MsgInput.TabIndex = 4;
      // 
      // MessageFeed
      // 
      this.MessageFeed.Location = new System.Drawing.Point(17, 51);
      this.MessageFeed.Name = "MessageFeed";
      this.MessageFeed.Size = new System.Drawing.Size(775, 332);
      this.MessageFeed.TabIndex = 5;
      this.MessageFeed.Text = "";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.label1.Location = new System.Drawing.Point(17, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 17);
      this.label1.TabIndex = 6;
      this.label1.Text = "ChatServer";
      // 
      // ChatClientGUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.MessageFeed);
      this.Controls.Add(this.MsgInput);
      this.Controls.Add(this.SendButton);
      this.Controls.Add(this.ConnectButton);
      this.Name = "ChatClientGUI";
      this.Text = "GabeChat Client";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
    private System.Windows.Forms.Button SendButton;
    private System.Windows.Forms.TextBox MsgInput;
    private System.Windows.Forms.RichTextBox MessageFeed;
    private System.Windows.Forms.Label label1;
  }
}

