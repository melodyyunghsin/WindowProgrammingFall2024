namespace F74126343_practice_6_1
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
            this.startButton = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.InventoryBar = new System.Windows.Forms.Panel();
            this.inventoryWater = new System.Windows.Forms.PictureBox();
            this.inventoryGrass = new System.Windows.Forms.PictureBox();
            this.inventoryStone = new System.Windows.Forms.PictureBox();
            this.inventoryDirt = new System.Windows.Forms.PictureBox();
            this.selectedFrame = new System.Windows.Forms.PictureBox();
            this.landscapePanel = new System.Windows.Forms.Panel();
            this.steve = new System.Windows.Forms.PictureBox();
            this.startPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.viewPanel.SuspendLayout();
            this.InventoryBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedFrame)).BeginInit();
            this.landscapePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.steve)).BeginInit();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.AutoSize = true;
            this.startPanel.Controls.Add(this.viewPanel);
            this.startPanel.Controls.Add(this.gamePanel);
            this.startPanel.Controls.Add(this.startButton);
            this.startPanel.Controls.Add(this.pictureBox2);
            this.startPanel.Controls.Add(this.pictureBox1);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPanel.Location = new System.Drawing.Point(0, 0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(699, 450);
            this.startPanel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(249, 218);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 36);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(5, 429);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(671, 17);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Visible = false;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(679, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 427);
            this.vScrollBar1.TabIndex = 4;
            this.vScrollBar1.Visible = false;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::F74126343_practice_6_1.Properties.Resources.startPage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::F74126343_practice_6_1.Properties.Resources.MinecraftLogo;
            this.pictureBox2.Location = new System.Drawing.Point(215, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(699, 450);
            this.gamePanel.TabIndex = 6;
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.viewPanel);
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.InventoryBar);
            this.viewPanel.Controls.Add(this.landscapePanel);
            this.viewPanel.Location = new System.Drawing.Point(0, 2);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(676, 427);
            this.viewPanel.TabIndex = 2;
            this.viewPanel.Visible = false;
            // 
            // InventoryBar
            // 
            this.InventoryBar.BackgroundImage = global::F74126343_practice_6_1.Properties.Resources.ToolBar;
            this.InventoryBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InventoryBar.Controls.Add(this.inventoryWater);
            this.InventoryBar.Controls.Add(this.inventoryGrass);
            this.InventoryBar.Controls.Add(this.inventoryStone);
            this.InventoryBar.Controls.Add(this.inventoryDirt);
            this.InventoryBar.Controls.Add(this.selectedFrame);
            this.InventoryBar.Location = new System.Drawing.Point(130, 369);
            this.InventoryBar.Name = "InventoryBar";
            this.InventoryBar.Size = new System.Drawing.Size(430, 54);
            this.InventoryBar.TabIndex = 1;
            // 
            // inventoryWater
            // 
            this.inventoryWater.Image = global::F74126343_practice_6_1.Properties.Resources.Water;
            this.inventoryWater.Location = new System.Drawing.Point(155, 14);
            this.inventoryWater.Name = "inventoryWater";
            this.inventoryWater.Size = new System.Drawing.Size(25, 25);
            this.inventoryWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryWater.TabIndex = 3;
            this.inventoryWater.TabStop = false;
            // 
            // inventoryGrass
            // 
            this.inventoryGrass.Image = global::F74126343_practice_6_1.Properties.Resources.GrassDirt;
            this.inventoryGrass.Location = new System.Drawing.Point(60, 14);
            this.inventoryGrass.Name = "inventoryGrass";
            this.inventoryGrass.Size = new System.Drawing.Size(25, 25);
            this.inventoryGrass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryGrass.TabIndex = 2;
            this.inventoryGrass.TabStop = false;
            // 
            // inventoryStone
            // 
            this.inventoryStone.Image = global::F74126343_practice_6_1.Properties.Resources.Stone;
            this.inventoryStone.Location = new System.Drawing.Point(108, 14);
            this.inventoryStone.Name = "inventoryStone";
            this.inventoryStone.Size = new System.Drawing.Size(25, 25);
            this.inventoryStone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryStone.TabIndex = 1;
            this.inventoryStone.TabStop = false;
            // 
            // inventoryDirt
            // 
            this.inventoryDirt.Image = global::F74126343_practice_6_1.Properties.Resources.Dirt;
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
            this.selectedFrame.Image = global::F74126343_practice_6_1.Properties.Resources.SelectedFrame;
            this.selectedFrame.Location = new System.Drawing.Point(0, 0);
            this.selectedFrame.Name = "selectedFrame";
            this.selectedFrame.Size = new System.Drawing.Size(54, 53);
            this.selectedFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedFrame.TabIndex = 4;
            this.selectedFrame.TabStop = false;
            // 
            // landscapePanel
            // 
            this.landscapePanel.Controls.Add(this.steve);
            this.landscapePanel.Location = new System.Drawing.Point(9, 9);
            this.landscapePanel.Margin = new System.Windows.Forms.Padding(0);
            this.landscapePanel.Name = "landscapePanel";
            this.landscapePanel.Size = new System.Drawing.Size(1500, 750);
            this.landscapePanel.TabIndex = 0;
            // 
            // steve
            // 
            this.steve.Image = global::F74126343_practice_6_1.Properties.Resources.Steve;
            this.steve.Location = new System.Drawing.Point(0, 300);
            this.steve.Name = "steve";
            this.steve.Size = new System.Drawing.Size(50, 95);
            this.steve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.steve.TabIndex = 0;
            this.steve.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.startPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.viewPanel.ResumeLayout(false);
            this.InventoryBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedFrame)).EndInit();
            this.landscapePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.steve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Panel InventoryBar;
        private System.Windows.Forms.PictureBox inventoryWater;
        private System.Windows.Forms.PictureBox inventoryGrass;
        private System.Windows.Forms.PictureBox inventoryStone;
        private System.Windows.Forms.PictureBox inventoryDirt;
        private System.Windows.Forms.PictureBox selectedFrame;
        private System.Windows.Forms.Panel landscapePanel;
        private System.Windows.Forms.PictureBox steve;
        private System.Windows.Forms.Panel gamePanel;
    }
}

