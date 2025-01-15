namespace F74126343_practice_3_2
{
    partial class Form1
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
            this.broadcastText = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listOrderBox = new System.Windows.Forms.TextBox();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.listOrderButton = new System.Windows.Forms.Button();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.penguinButton = new System.Windows.Forms.Button();
            this.tonkatsuButton = new System.Windows.Forms.Button();
            this.shrimpButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.newAccButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // broadcastText
            // 
            this.broadcastText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.broadcastText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.broadcastText.Enabled = false;
            this.broadcastText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broadcastText.Location = new System.Drawing.Point(175, 40);
            this.broadcastText.Name = "broadcastText";
            this.broadcastText.ReadOnly = true;
            this.broadcastText.Size = new System.Drawing.Size(400, 20);
            this.broadcastText.TabIndex = 0;
            this.broadcastText.Text = "歡迎來到角落生物商店";
            this.broadcastText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openButton
            // 
            this.openButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.openButton.Location = new System.Drawing.Point(175, 175);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(400, 125);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open Shop";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(114, 202);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(114, 258);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Visible = false;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(175, 199);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(400, 20);
            this.usernameBox.TabIndex = 4;
            this.usernameBox.Visible = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(175, 255);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(400, 20);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginButton.Location = new System.Drawing.Point(610, 215);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 45);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(175, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(0, 4);
            this.listBox1.TabIndex = 8;
            // 
            // listOrderBox
            // 
            this.listOrderBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOrderBox.Location = new System.Drawing.Point(175, 93);
            this.listOrderBox.Multiline = true;
            this.listOrderBox.Name = "listOrderBox";
            this.listOrderBox.ReadOnly = true;
            this.listOrderBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.listOrderBox.Size = new System.Drawing.Size(510, 336);
            this.listOrderBox.TabIndex = 9;
            this.listOrderBox.Visible = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newOrderButton.Location = new System.Drawing.Point(25, 93);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(125, 60);
            this.newOrderButton.TabIndex = 10;
            this.newOrderButton.Text = "Add a New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Visible = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // listOrderButton
            // 
            this.listOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listOrderButton.Location = new System.Drawing.Point(25, 175);
            this.listOrderButton.Name = "listOrderButton";
            this.listOrderButton.Size = new System.Drawing.Size(125, 60);
            this.listOrderButton.TabIndex = 11;
            this.listOrderButton.Text = "List All Order";
            this.listOrderButton.UseVisualStyleBackColor = false;
            this.listOrderButton.Visible = false;
            this.listOrderButton.Click += new System.EventHandler(this.listOrderButton_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(245, 114);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(330, 20);
            this.quantityBox.TabIndex = 12;
            this.quantityBox.Visible = false;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(172, 117);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(67, 13);
            this.quantityLabel.TabIndex = 13;
            this.quantityLabel.Text = "請輸入數量";
            this.quantityLabel.Visible = false;
            // 
            // penguinButton
            // 
            this.penguinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.penguinButton.Location = new System.Drawing.Point(175, 175);
            this.penguinButton.Name = "penguinButton";
            this.penguinButton.Size = new System.Drawing.Size(125, 60);
            this.penguinButton.TabIndex = 14;
            this.penguinButton.Text = "企鵝";
            this.penguinButton.UseVisualStyleBackColor = false;
            this.penguinButton.Visible = false;
            this.penguinButton.Click += new System.EventHandler(this.penguinButton_Click);
            // 
            // tonkatsuButton
            // 
            this.tonkatsuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tonkatsuButton.Location = new System.Drawing.Point(313, 175);
            this.tonkatsuButton.Name = "tonkatsuButton";
            this.tonkatsuButton.Size = new System.Drawing.Size(125, 60);
            this.tonkatsuButton.TabIndex = 15;
            this.tonkatsuButton.Text = "炸豬排";
            this.tonkatsuButton.UseVisualStyleBackColor = false;
            this.tonkatsuButton.Visible = false;
            this.tonkatsuButton.Click += new System.EventHandler(this.tonkatsuButton_Click);
            // 
            // shrimpButton
            // 
            this.shrimpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.shrimpButton.Location = new System.Drawing.Point(450, 175);
            this.shrimpButton.Name = "shrimpButton";
            this.shrimpButton.Size = new System.Drawing.Size(125, 60);
            this.shrimpButton.TabIndex = 16;
            this.shrimpButton.Text = "炸蝦";
            this.shrimpButton.UseVisualStyleBackColor = false;
            this.shrimpButton.Visible = false;
            this.shrimpButton.Click += new System.EventHandler(this.shrimpButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.placeOrderButton.Location = new System.Drawing.Point(313, 258);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(125, 60);
            this.placeOrderButton.TabIndex = 17;
            this.placeOrderButton.Text = "送出訂單";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Visible = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // newAccButton
            // 
            this.newAccButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newAccButton.Location = new System.Drawing.Point(25, 258);
            this.newAccButton.Name = "newAccButton";
            this.newAccButton.Size = new System.Drawing.Size(125, 60);
            this.newAccButton.TabIndex = 18;
            this.newAccButton.Text = "Create New Account";
            this.newAccButton.UseVisualStyleBackColor = false;
            this.newAccButton.Visible = false;
            this.newAccButton.Click += new System.EventHandler(this.newAccButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logOutButton.Location = new System.Drawing.Point(25, 343);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(125, 60);
            this.logOutButton.TabIndex = 19;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Visible = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createButton.Location = new System.Drawing.Point(610, 215);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 45);
            this.createButton.TabIndex = 20;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Visible = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.newAccButton);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.shrimpButton);
            this.Controls.Add(this.tonkatsuButton);
            this.Controls.Add(this.penguinButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.listOrderButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.listOrderBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.broadcastText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox broadcastText;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox listOrderBox;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button listOrderButton;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button penguinButton;
        private System.Windows.Forms.Button tonkatsuButton;
        private System.Windows.Forms.Button shrimpButton;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Button newAccButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button createButton;
    }
}

