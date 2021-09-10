
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatClientGUI));
      this.ConnectButton = new System.Windows.Forms.Button();
      this.lblHelloWorld = new System.Windows.Forms.Label();
      this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.SendButton = new System.Windows.Forms.Button();
      this.MsgInput = new System.Windows.Forms.TextBox();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
      this.bindingNavigator1.SuspendLayout();
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
      // lblHelloWorld
      // 
      this.lblHelloWorld.AutoSize = true;
      this.lblHelloWorld.Location = new System.Drawing.Point(12, 9);
      this.lblHelloWorld.Name = "lblHelloWorld";
      this.lblHelloWorld.Size = new System.Drawing.Size(80, 13);
      this.lblHelloWorld.TabIndex = 1;
      this.lblHelloWorld.Text = "This is the label";
      // 
      // bindingNavigator1
      // 
      this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
      this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
      this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
      this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
      this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigator1.Name = "bindingNavigator1";
      this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
      this.bindingNavigator1.TabIndex = 2;
      this.bindingNavigator1.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(17, 51);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(775, 332);
      this.richTextBox1.TabIndex = 5;
      this.richTextBox1.Text = "";
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.MsgInput);
      this.Controls.Add(this.SendButton);
      this.Controls.Add(this.bindingNavigator1);
      this.Controls.Add(this.lblHelloWorld);
      this.Controls.Add(this.ConnectButton);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
      this.bindingNavigator1.ResumeLayout(false);
      this.bindingNavigator1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label lblHelloWorld;
    private System.Windows.Forms.BindingNavigator bindingNavigator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.Button SendButton;
    private System.Windows.Forms.TextBox MsgInput;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Label label1;
  }
}

