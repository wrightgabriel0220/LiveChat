
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
      this.components = new System.ComponentModel.Container();
      this.ConnectButton = new System.Windows.Forms.Button();
      this.SendButton = new System.Windows.Forms.Button();
      this.MsgInput = new System.Windows.Forms.TextBox();
      this.MessageFeed = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.RoomsSelect = new System.Windows.Forms.ComboBox();
      this.RoomLabel = new System.Windows.Forms.Label();
      this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
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
      this.MsgInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgInput_KeyDown);
      // 
      // MessageFeed
      // 
      this.MessageFeed.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.MessageFeed.Location = new System.Drawing.Point(17, 51);
      this.MessageFeed.Name = "MessageFeed";
      this.MessageFeed.ReadOnly = true;
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
      // RoomsSelect
      // 
      this.RoomsSelect.FormattingEnabled = true;
      this.RoomsSelect.Location = new System.Drawing.Point(58, 5);
      this.RoomsSelect.Name = "RoomsSelect";
      this.RoomsSelect.Size = new System.Drawing.Size(121, 21);
      this.RoomsSelect.TabIndex = 7;
      this.RoomsSelect.TextChanged += new System.EventHandler(this.RoomsSelectChange);
      // 
      // RoomLabel
      // 
      this.RoomLabel.AutoSize = true;
      this.RoomLabel.Location = new System.Drawing.Point(17, 8);
      this.RoomLabel.Name = "RoomLabel";
      this.RoomLabel.Size = new System.Drawing.Size(38, 13);
      this.RoomLabel.TabIndex = 8;
      this.RoomLabel.Text = "Room:";
      // 
      // clientBindingSource
      // 
      this.clientBindingSource.DataSource = typeof(ChatClient.Models.Client);
      // 
      // clientBindingSource1
      // 
      this.clientBindingSource1.DataSource = typeof(ChatClient.Models.Client);
      // 
      // ChatClientGUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.RoomLabel);
      this.Controls.Add(this.RoomsSelect);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.MessageFeed);
      this.Controls.Add(this.MsgInput);
      this.Controls.Add(this.SendButton);
      this.Controls.Add(this.ConnectButton);
      this.Name = "ChatClientGUI";
      this.Text = "GabeChat Client";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatClientGUI_FormClosed);
      this.Load += new System.EventHandler(this.ChatClientGUI_Load);
      ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
    private System.Windows.Forms.Button SendButton;
    private System.Windows.Forms.TextBox MsgInput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox MessageFeed;
    private System.Windows.Forms.ComboBox RoomsSelect;
    private System.Windows.Forms.Label RoomLabel;
    private System.Windows.Forms.BindingSource clientBindingSource;
    private System.Windows.Forms.BindingSource clientBindingSource1;
  }
}

