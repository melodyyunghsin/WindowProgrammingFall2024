namespace F74126343_practice_4_2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stickerButton1 = new System.Windows.Forms.Button();
            this.chatRoom1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chatRoom2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.stickerButton2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 500);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stickerButton1);
            this.tabPage1.Controls.Add(this.chatRoom1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "斗哥";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // stickerButton1
            // 
            this.stickerButton1.BackgroundImage = global::F74126343_practice_4_2.Properties.Resources.button;
            this.stickerButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stickerButton1.Location = new System.Drawing.Point(378, 448);
            this.stickerButton1.Name = "stickerButton1";
            this.stickerButton1.Size = new System.Drawing.Size(23, 23);
            this.stickerButton1.TabIndex = 3;
            this.stickerButton1.UseVisualStyleBackColor = true;
            this.stickerButton1.Click += new System.EventHandler(this.stickerButton1_Click);
            // 
            // chatRoom1
            // 
            this.chatRoom1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatRoom1.AutoScroll = true;
            this.chatRoom1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatRoom1.Location = new System.Drawing.Point(0, 0);
            this.chatRoom1.Name = "chatRoom1";
            this.chatRoom1.Size = new System.Drawing.Size(473, 444);
            this.chatRoom1.TabIndex = 2;
            this.chatRoom1.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(400, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 450);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stickerButton2);
            this.tabPage2.Controls.Add(this.chatRoom2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "楷特";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chatRoom2
            // 
            this.chatRoom2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatRoom2.Location = new System.Drawing.Point(0, 0);
            this.chatRoom2.Name = "chatRoom2";
            this.chatRoom2.Size = new System.Drawing.Size(473, 445);
            this.chatRoom2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(400, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(3, 451);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 20);
            this.textBox2.TabIndex = 1;
            // 
            // stickerButton2
            // 
            this.stickerButton2.BackgroundImage = global::F74126343_practice_4_2.Properties.Resources.button;
            this.stickerButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stickerButton2.Location = new System.Drawing.Point(378, 449);
            this.stickerButton2.Name = "stickerButton2";
            this.stickerButton2.Size = new System.Drawing.Size(23, 23);
            this.stickerButton2.TabIndex = 5;
            this.stickerButton2.UseVisualStyleBackColor = true;
            this.stickerButton2.Click += new System.EventHandler(this.stickerButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 504);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FlowLayoutPanel chatRoom2;
        private System.Windows.Forms.Button stickerButton1;
        private System.Windows.Forms.FlowLayoutPanel chatRoom1;
        private System.Windows.Forms.Button stickerButton2;
    }
}

