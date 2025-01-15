namespace F74126343_practice_6_2
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
            this.startPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.InventoryBar = new System.Windows.Forms.Panel();
            this.inventoryWater = new System.Windows.Forms.PictureBox();
            this.inventoryGrass = new System.Windows.Forms.PictureBox();
            this.inventoryStone = new System.Windows.Forms.PictureBox();
            this.inventoryDirt = new System.Windows.Forms.PictureBox();
            this.selectedFrame = new System.Windows.Forms.PictureBox();
            this.landscapePanel = new System.Windows.Forms.Panel();
            this.steve = new System.Windows.Forms.PictureBox();
            this.pausePanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.startPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gamePanel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.InventoryBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedFrame)).BeginInit();
            this.landscapePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.steve)).BeginInit();
            this.pausePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.AutoSize = true;
            this.startPanel.Controls.Add(this.exitButton);
            this.startPanel.Controls.Add(this.openFileButton);
            this.startPanel.Controls.Add(this.startButton);
            this.startPanel.Controls.Add(this.pictureBox2);
            this.startPanel.Controls.Add(this.pictureBox1);
            this.startPanel.Location = new System.Drawing.Point(1, 0);
            this.startPanel.Margin = new System.Windows.Forms.Padding(0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(702, 453);
            this.startPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(249, 319);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 36);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += exitButton_Click;
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.Location = new System.Drawing.Point(249, 259);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(200, 36);
            this.openFileButton.TabIndex = 5;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(249, 200);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 36);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::F74126343_practice_6_2.Properties.Resources.MinecraftLogo;
            this.pictureBox2.Location = new System.Drawing.Point(196, 124);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F74126343_practice_6_2.Properties.Resources.startPage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.hScrollBar1);
            this.gamePanel.Controls.Add(this.vScrollBar1);
            this.gamePanel.Controls.Add(this.viewPanel);
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(698, 450);
            this.gamePanel.TabIndex = 2;
            this.gamePanel.Visible = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(1, 433);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(680, 17);
            this.hScrollBar1.TabIndex = 9;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(681, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 427);
            this.vScrollBar1.TabIndex = 8;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.InventoryBar);
            this.viewPanel.Controls.Add(this.landscapePanel);
            this.viewPanel.Location = new System.Drawing.Point(0, 0);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(681, 433);
            this.viewPanel.TabIndex = 7;
            this.viewPanel.Visible = false;
            // 
            // InventoryBar
            // 
            this.InventoryBar.BackgroundImage = global::F74126343_practice_6_2.Properties.Resources.ToolBar;
            this.InventoryBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InventoryBar.Controls.Add(this.inventoryWater);
            this.InventoryBar.Controls.Add(this.inventoryGrass);
            this.InventoryBar.Controls.Add(this.inventoryStone);
            this.InventoryBar.Controls.Add(this.inventoryDirt);
            this.InventoryBar.Controls.Add(this.selectedFrame);
            this.InventoryBar.Location = new System.Drawing.Point(130, 371);
            this.InventoryBar.Name = "InventoryBar";
            this.InventoryBar.Size = new System.Drawing.Size(430, 54);
            this.InventoryBar.TabIndex = 1;
            // 
            // inventoryWater
            // 
            this.inventoryWater.Image = global::F74126343_practice_6_2.Properties.Resources.Water;
            this.inventoryWater.Location = new System.Drawing.Point(155, 14);
            this.inventoryWater.Name = "inventoryWater";
            this.inventoryWater.Size = new System.Drawing.Size(25, 25);
            this.inventoryWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryWater.TabIndex = 3;
            this.inventoryWater.TabStop = false;
            // 
            // inventoryGrass
            // 
            this.inventoryGrass.Image = global::F74126343_practice_6_2.Properties.Resources.GrassDirt;
            this.inventoryGrass.Location = new System.Drawing.Point(60, 14);
            this.inventoryGrass.Name = "inventoryGrass";
            this.inventoryGrass.Size = new System.Drawing.Size(25, 25);
            this.inventoryGrass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryGrass.TabIndex = 2;
            this.inventoryGrass.TabStop = false;
            // 
            // inventoryStone
            // 
            this.inventoryStone.Image = global::F74126343_practice_6_2.Properties.Resources.Stone;
            this.inventoryStone.Location = new System.Drawing.Point(108, 14);
            this.inventoryStone.Name = "inventoryStone";
            this.inventoryStone.Size = new System.Drawing.Size(25, 25);
            this.inventoryStone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryStone.TabIndex = 1;
            this.inventoryStone.TabStop = false;
            // 
            // inventoryDirt
            // 
            this.inventoryDirt.Image = global::F74126343_practice_6_2.Properties.Resources.Dirt;
            this.inventoryDirt.Location = new System.Drawing.Point(13, 14);
            this.inventoryDirt.Name = "inventoryDirt";
            this.inventoryDirt.Size = new System.Drawing.Size(25, 25);
            this.inventoryDirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryDirt.TabIndex = 0;
            this.inventoryDirt.TabStop = false;
            // 
            // selectedFrame
            // 
            this.selectedFrame.BackColor = System.Drawing.Color.Transparent;
            this.selectedFrame.Image = global::F74126343_practice_6_2.Properties.Resources.SelectedFrame;
            this.selectedFrame.Location = new System.Drawing.Point(0, 0);
            this.selectedFrame.Name = "selectedFrame";
            this.selectedFrame.Size = new System.Drawing.Size(54, 53);
            this.selectedFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedFrame.TabIndex = 4;
            this.selectedFrame.TabStop = false;
            // 
            // landscapePanel
            // 
            this.landscapePanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.landscapePanel.Controls.Add(this.steve);
            this.landscapePanel.Location = new System.Drawing.Point(0, 0);
            this.landscapePanel.Margin = new System.Windows.Forms.Padding(0);
            this.landscapePanel.Name = "landscapePanel";
            this.landscapePanel.Size = new System.Drawing.Size(1500, 750);
            this.landscapePanel.TabIndex = 0;
            // 
            // steve
            // 
            this.steve.Image = global::F74126343_practice_6_2.Properties.Resources.Steve;
            this.steve.Location = new System.Drawing.Point(0, 300);
            this.steve.Name = "steve";
            this.steve.Size = new System.Drawing.Size(50, 95);
            this.steve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.steve.TabIndex = 0;
            this.steve.TabStop = false;
            // 
            // pausePanel
            // 
            this.pausePanel.BackColor = System.Drawing.Color.DarkGray;
            this.pausePanel.Controls.Add(this.backButton);
            this.pausePanel.Controls.Add(this.saveFileButton);
            this.pausePanel.Controls.Add(this.resumeButton);
            this.pausePanel.Location = new System.Drawing.Point(1, 0);
            this.pausePanel.Name = "pausePanel";
            this.pausePanel.Size = new System.Drawing.Size(698, 450);
            this.pausePanel.TabIndex = 5;
            this.pausePanel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(234, 259);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(230, 45);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back to Home Page";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileButton.Location = new System.Drawing.Point(234, 203);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(230, 45);
            this.saveFileButton.TabIndex = 1;
            this.saveFileButton.Text = "Save File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeButton.Location = new System.Drawing.Point(235, 150);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(230, 45);
            this.resumeButton.TabIndex = 0;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.pausePanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.startPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.startPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            this.InventoryBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedFrame)).EndInit();
            this.landscapePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.steve)).EndInit();
            this.pausePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Panel InventoryBar;
        private System.Windows.Forms.PictureBox inventoryWater;
        private System.Windows.Forms.PictureBox inventoryGrass;
        private System.Windows.Forms.PictureBox inventoryStone;
        private System.Windows.Forms.PictureBox inventoryDirt;
        private System.Windows.Forms.PictureBox selectedFrame;
        private System.Windows.Forms.Panel landscapePanel;
        private System.Windows.Forms.PictureBox steve;
        private System.Windows.Forms.Panel pausePanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button resumeButton;
    }
}

