namespace F74126343_practice_5_2
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
            this.launchButton = new System.Windows.Forms.Button();
            this.characterSelectionPanel = new System.Windows.Forms.Panel();
            this.characterSelectionPrompt = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.shawCheckBox = new System.Windows.Forms.CheckBox();
            this.melanthaCheckBox = new System.Windows.Forms.CheckBox();
            this.myrtleCheckBox = new System.Windows.Forms.CheckBox();
            this.cardiganCheckBox = new System.Windows.Forms.CheckBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.characterStats = new System.Windows.Forms.Label();
            this.characterQueuePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CardiganBox = new System.Windows.Forms.Panel();
            this.cardiganCDTimer = new System.Windows.Forms.Label();
            this.cardiganHP = new System.Windows.Forms.Label();
            this.cardiganCostLabel = new System.Windows.Forms.Label();
            this.cardiganNameLabel = new System.Windows.Forms.Label();
            this.MyrtleBox = new System.Windows.Forms.Panel();
            this.myrtleCDTimer = new System.Windows.Forms.Label();
            this.myrtleHP = new System.Windows.Forms.Label();
            this.myrtleCostLabel = new System.Windows.Forms.Label();
            this.myrtleNameLabel = new System.Windows.Forms.Label();
            this.MelanthaBox = new System.Windows.Forms.Panel();
            this.melanthaCDTimer = new System.Windows.Forms.Label();
            this.melanthaHP = new System.Windows.Forms.Label();
            this.melanthaCostLabel = new System.Windows.Forms.Label();
            this.melanthaNameLabel = new System.Windows.Forms.Label();
            this.ShawBox = new System.Windows.Forms.Panel();
            this.shawCDTimer = new System.Windows.Forms.Label();
            this.shawHP = new System.Windows.Forms.Label();
            this.shawCostLabel = new System.Windows.Forms.Label();
            this.shawNameLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.livesLabel = new System.Windows.Forms.Label();
            this.gameGrid = new System.Windows.Forms.TableLayoutPanel();
            this.characterSelectionPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.characterQueuePanel.SuspendLayout();
            this.CardiganBox.SuspendLayout();
            this.MyrtleBox.SuspendLayout();
            this.MelanthaBox.SuspendLayout();
            this.ShawBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(312, 200);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(100, 30);
            this.launchButton.TabIndex = 0;
            this.launchButton.Text = "開始遊戲";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // characterSelectionPanel
            // 
            this.characterSelectionPanel.Controls.Add(this.characterSelectionPrompt);
            this.characterSelectionPanel.Controls.Add(this.startButton);
            this.characterSelectionPanel.Controls.Add(this.shawCheckBox);
            this.characterSelectionPanel.Controls.Add(this.melanthaCheckBox);
            this.characterSelectionPanel.Controls.Add(this.myrtleCheckBox);
            this.characterSelectionPanel.Controls.Add(this.cardiganCheckBox);
            this.characterSelectionPanel.Location = new System.Drawing.Point(0, -1);
            this.characterSelectionPanel.Name = "characterSelectionPanel";
            this.characterSelectionPanel.Size = new System.Drawing.Size(735, 412);
            this.characterSelectionPanel.TabIndex = 1;
            this.characterSelectionPanel.Visible = false;
            // 
            // characterSelectionPrompt
            // 
            this.characterSelectionPrompt.AutoSize = true;
            this.characterSelectionPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterSelectionPrompt.Location = new System.Drawing.Point(321, 133);
            this.characterSelectionPrompt.Name = "characterSelectionPrompt";
            this.characterSelectionPrompt.Size = new System.Drawing.Size(72, 13);
            this.characterSelectionPrompt.TabIndex = 5;
            this.characterSelectionPrompt.Text = "請選擇角色";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(317, 251);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // shawCheckBox
            // 
            this.shawCheckBox.AutoSize = true;
            this.shawCheckBox.Location = new System.Drawing.Point(324, 228);
            this.shawCheckBox.Name = "shawCheckBox";
            this.shawCheckBox.Size = new System.Drawing.Size(53, 17);
            this.shawCheckBox.TabIndex = 3;
            this.shawCheckBox.Text = "Shaw";
            this.shawCheckBox.UseVisualStyleBackColor = true;
            // 
            // melanthaCheckBox
            // 
            this.melanthaCheckBox.AutoSize = true;
            this.melanthaCheckBox.Location = new System.Drawing.Point(324, 205);
            this.melanthaCheckBox.Name = "melanthaCheckBox";
            this.melanthaCheckBox.Size = new System.Drawing.Size(70, 17);
            this.melanthaCheckBox.TabIndex = 2;
            this.melanthaCheckBox.Text = "Melantha";
            this.melanthaCheckBox.UseVisualStyleBackColor = true;
            // 
            // myrtleCheckBox
            // 
            this.myrtleCheckBox.AutoSize = true;
            this.myrtleCheckBox.Location = new System.Drawing.Point(324, 182);
            this.myrtleCheckBox.Name = "myrtleCheckBox";
            this.myrtleCheckBox.Size = new System.Drawing.Size(54, 17);
            this.myrtleCheckBox.TabIndex = 1;
            this.myrtleCheckBox.Text = "Myrtle";
            this.myrtleCheckBox.UseVisualStyleBackColor = true;
            // 
            // cardiganCheckBox
            // 
            this.cardiganCheckBox.AutoSize = true;
            this.cardiganCheckBox.Location = new System.Drawing.Point(324, 159);
            this.cardiganCheckBox.Name = "cardiganCheckBox";
            this.cardiganCheckBox.Size = new System.Drawing.Size(68, 17);
            this.cardiganCheckBox.TabIndex = 0;
            this.cardiganCheckBox.Text = "Cardigan";
            this.cardiganCheckBox.UseVisualStyleBackColor = true;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.characterStats);
            this.gamePanel.Controls.Add(this.characterQueuePanel);
            this.gamePanel.Controls.Add(this.pointLabel);
            this.gamePanel.Controls.Add(this.livesLabel);
            this.gamePanel.Controls.Add(this.gameGrid);
            this.gamePanel.Location = new System.Drawing.Point(0, 1);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(732, 409);
            this.gamePanel.TabIndex = 7;
            this.gamePanel.Visible = false;
            // 
            // characterStats
            // 
            this.characterStats.AutoSize = true;
            this.characterStats.Location = new System.Drawing.Point(646, 19);
            this.characterStats.Name = "characterStats";
            this.characterStats.Size = new System.Drawing.Size(76, 13);
            this.characterStats.TabIndex = 5;
            this.characterStats.Text = "characterStats";
            this.characterStats.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.characterStats.Visible = false;
            // 
            // characterQueuePanel
            // 
            this.characterQueuePanel.AllowDrop = true;
            this.characterQueuePanel.Controls.Add(this.CardiganBox);
            this.characterQueuePanel.Controls.Add(this.MyrtleBox);
            this.characterQueuePanel.Controls.Add(this.MelanthaBox);
            this.characterQueuePanel.Controls.Add(this.ShawBox);
            this.characterQueuePanel.Location = new System.Drawing.Point(12, 309);
            this.characterQueuePanel.Margin = new System.Windows.Forms.Padding(0);
            this.characterQueuePanel.Name = "characterQueuePanel";
            this.characterQueuePanel.Size = new System.Drawing.Size(260, 65);
            this.characterQueuePanel.TabIndex = 4;
            // 
            // CardiganBox
            // 
            this.CardiganBox.BackColor = System.Drawing.Color.White;
            this.CardiganBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardiganBox.Controls.Add(this.cardiganCDTimer);
            this.CardiganBox.Controls.Add(this.cardiganHP);
            this.CardiganBox.Controls.Add(this.cardiganCostLabel);
            this.CardiganBox.Controls.Add(this.cardiganNameLabel);
            this.CardiganBox.Location = new System.Drawing.Point(0, 0);
            this.CardiganBox.Margin = new System.Windows.Forms.Padding(0);
            this.CardiganBox.Name = "CardiganBox";
            this.CardiganBox.Size = new System.Drawing.Size(65, 65);
            this.CardiganBox.TabIndex = 6;
            this.CardiganBox.Visible = false;
            this.CardiganBox.Click += new System.EventHandler(this.CardiganBox_Click);
            this.CardiganBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.characterBox_RightClick);
            this.CardiganBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseDown);
            this.CardiganBox.MouseHover += new System.EventHandler(this.characterBox_MouseHover);
            this.CardiganBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseMove);
            this.CardiganBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseUp);
            // 
            // cardiganCDTimer
            // 
            this.cardiganCDTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardiganCDTimer.AutoSize = true;
            this.cardiganCDTimer.Location = new System.Drawing.Point(15, 45);
            this.cardiganCDTimer.Name = "cardiganCDTimer";
            this.cardiganCDTimer.Size = new System.Drawing.Size(35, 13);
            this.cardiganCDTimer.TabIndex = 3;
            this.cardiganCDTimer.Text = "label2";
            this.cardiganCDTimer.Visible = false;
            this.cardiganCDTimer.Click += new System.EventHandler(this.CardiganBox_Click);
            this.cardiganCDTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // cardiganHP
            // 
            this.cardiganHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardiganHP.AutoSize = true;
            this.cardiganHP.Location = new System.Drawing.Point(15, 29);
            this.cardiganHP.Name = "cardiganHP";
            this.cardiganHP.Size = new System.Drawing.Size(35, 13);
            this.cardiganHP.TabIndex = 2;
            this.cardiganHP.Text = "label1";
            this.cardiganHP.Visible = false;
            this.cardiganHP.Click += new System.EventHandler(this.CardiganBox_Click);
            this.cardiganHP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // cardiganCostLabel
            // 
            this.cardiganCostLabel.AutoSize = true;
            this.cardiganCostLabel.Location = new System.Drawing.Point(23, 35);
            this.cardiganCostLabel.Name = "cardiganCostLabel";
            this.cardiganCostLabel.Size = new System.Drawing.Size(19, 13);
            this.cardiganCostLabel.TabIndex = 1;
            this.cardiganCostLabel.Text = "18";
            this.cardiganCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cardiganCostLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // cardiganNameLabel
            // 
            this.cardiganNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardiganNameLabel.AutoSize = true;
            this.cardiganNameLabel.Location = new System.Drawing.Point(8, 12);
            this.cardiganNameLabel.Name = "cardiganNameLabel";
            this.cardiganNameLabel.Size = new System.Drawing.Size(49, 13);
            this.cardiganNameLabel.TabIndex = 0;
            this.cardiganNameLabel.Text = "Cardigan";
            this.cardiganNameLabel.Click += new System.EventHandler(this.CardiganBox_Click);
            this.cardiganNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cardiganNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // MyrtleBox
            // 
            this.MyrtleBox.BackColor = System.Drawing.Color.White;
            this.MyrtleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyrtleBox.Controls.Add(this.myrtleCDTimer);
            this.MyrtleBox.Controls.Add(this.myrtleHP);
            this.MyrtleBox.Controls.Add(this.myrtleCostLabel);
            this.MyrtleBox.Controls.Add(this.myrtleNameLabel);
            this.MyrtleBox.Location = new System.Drawing.Point(65, 0);
            this.MyrtleBox.Margin = new System.Windows.Forms.Padding(0);
            this.MyrtleBox.Name = "MyrtleBox";
            this.MyrtleBox.Size = new System.Drawing.Size(65, 65);
            this.MyrtleBox.TabIndex = 7;
            this.MyrtleBox.Visible = false;
            this.MyrtleBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.characterBox_RightClick);
            this.MyrtleBox.Click += new System.EventHandler(this.MyrtleBox_Click);
            this.MyrtleBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseDown);
            this.MyrtleBox.MouseHover += new System.EventHandler(this.characterBox_MouseHover);
            this.MyrtleBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseMove);
            this.MyrtleBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseUp);
            // 
            // myrtleCDTimer
            // 
            this.myrtleCDTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myrtleCDTimer.AutoSize = true;
            this.myrtleCDTimer.Location = new System.Drawing.Point(14, 45);
            this.myrtleCDTimer.Name = "myrtleCDTimer";
            this.myrtleCDTimer.Size = new System.Drawing.Size(35, 13);
            this.myrtleCDTimer.TabIndex = 5;
            this.myrtleCDTimer.Text = "label2";
            this.myrtleCDTimer.Visible = false;
            this.myrtleCDTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            this.myrtleCDTimer.Click += new System.EventHandler(this.MyrtleBox_Click);
            // 
            // myrtleHP
            // 
            this.myrtleHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myrtleHP.AutoSize = true;
            this.myrtleHP.Location = new System.Drawing.Point(14, 29);
            this.myrtleHP.Name = "myrtleHP";
            this.myrtleHP.Size = new System.Drawing.Size(35, 13);
            this.myrtleHP.TabIndex = 4;
            this.myrtleHP.Text = "label1";
            this.myrtleHP.Visible = false;
            this.myrtleHP.Click += new System.EventHandler(this.MyrtleBox_Click);
            this.myrtleHP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // myrtleCostLabel
            // 
            this.myrtleCostLabel.AutoSize = true;
            this.myrtleCostLabel.Location = new System.Drawing.Point(23, 35);
            this.myrtleCostLabel.Name = "myrtleCostLabel";
            this.myrtleCostLabel.Size = new System.Drawing.Size(19, 13);
            this.myrtleCostLabel.TabIndex = 1;
            this.myrtleCostLabel.Text = "10";
            this.myrtleCostLabel.Click += new System.EventHandler(this.MyrtleBox_Click);
            this.myrtleCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myrtleCostLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // myrtleNameLabel
            // 
            this.myrtleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myrtleNameLabel.AutoSize = true;
            this.myrtleNameLabel.Location = new System.Drawing.Point(15, 12);
            this.myrtleNameLabel.Name = "myrtleNameLabel";
            this.myrtleNameLabel.Size = new System.Drawing.Size(35, 13);
            this.myrtleNameLabel.TabIndex = 0;
            this.myrtleNameLabel.Text = "Myrtle";
            this.myrtleNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myrtleNameLabel.Click += new System.EventHandler(this.MyrtleBox_Click);
            this.myrtleNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // MelanthaBox
            // 
            this.MelanthaBox.BackColor = System.Drawing.Color.White;
            this.MelanthaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MelanthaBox.Controls.Add(this.melanthaCDTimer);
            this.MelanthaBox.Controls.Add(this.melanthaHP);
            this.MelanthaBox.Controls.Add(this.melanthaCostLabel);
            this.MelanthaBox.Controls.Add(this.melanthaNameLabel);
            this.MelanthaBox.Location = new System.Drawing.Point(130, 0);
            this.MelanthaBox.Margin = new System.Windows.Forms.Padding(0);
            this.MelanthaBox.Name = "MelanthaBox";
            this.MelanthaBox.Size = new System.Drawing.Size(65, 65);
            this.MelanthaBox.TabIndex = 8;
            this.MelanthaBox.Visible = false;
            this.MelanthaBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.characterBox_RightClick);
            this.MelanthaBox.Click += new System.EventHandler(this.MelanthaBox_Click);
            this.MelanthaBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseDown);
            this.MelanthaBox.MouseHover += new System.EventHandler(this.characterBox_MouseHover);
            this.MelanthaBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseMove);
            this.MelanthaBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseUp);
            // 
            // melanthaCDTimer
            // 
            this.melanthaCDTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.melanthaCDTimer.AutoSize = true;
            this.melanthaCDTimer.Location = new System.Drawing.Point(14, 45);
            this.melanthaCDTimer.Name = "melanthaCDTimer";
            this.melanthaCDTimer.Size = new System.Drawing.Size(35, 13);
            this.melanthaCDTimer.TabIndex = 5;
            this.melanthaCDTimer.Text = "label2";
            this.melanthaCDTimer.Visible = false;
            this.melanthaCDTimer.Click += new System.EventHandler(this.MelanthaBox_Click);
            this.melanthaCDTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // melanthaHP
            // 
            this.melanthaHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.melanthaHP.AutoSize = true;
            this.melanthaHP.Location = new System.Drawing.Point(14, 29);
            this.melanthaHP.Name = "melanthaHP";
            this.melanthaHP.Size = new System.Drawing.Size(35, 13);
            this.melanthaHP.TabIndex = 4;
            this.melanthaHP.Text = "label1";
            this.melanthaHP.Visible = false;
            this.melanthaHP.Click += new System.EventHandler(this.MelanthaBox_Click);
            this.melanthaHP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // melanthaCostLabel
            // 
            this.melanthaCostLabel.AutoSize = true;
            this.melanthaCostLabel.Location = new System.Drawing.Point(23, 35);
            this.melanthaCostLabel.Name = "melanthaCostLabel";
            this.melanthaCostLabel.Size = new System.Drawing.Size(19, 13);
            this.melanthaCostLabel.TabIndex = 1;
            this.melanthaCostLabel.Text = "15";
            this.melanthaCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.melanthaCostLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // melanthaNameLabel
            // 
            this.melanthaNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.melanthaNameLabel.AutoSize = true;
            this.melanthaNameLabel.Location = new System.Drawing.Point(7, 12);
            this.melanthaNameLabel.Name = "melanthaNameLabel";
            this.melanthaNameLabel.Size = new System.Drawing.Size(51, 13);
            this.melanthaNameLabel.TabIndex = 0;
            this.melanthaNameLabel.Text = "Melantha";
            this.melanthaNameLabel.Click += new System.EventHandler(this.MelanthaBox_Click);
            this.melanthaNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.melanthaNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // ShawBox
            // 
            this.ShawBox.BackColor = System.Drawing.Color.White;
            this.ShawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShawBox.Controls.Add(this.shawCDTimer);
            this.ShawBox.Controls.Add(this.shawHP);
            this.ShawBox.Controls.Add(this.shawCostLabel);
            this.ShawBox.Controls.Add(this.shawNameLabel);
            this.ShawBox.Location = new System.Drawing.Point(195, 0);
            this.ShawBox.Margin = new System.Windows.Forms.Padding(0);
            this.ShawBox.Name = "ShawBox";
            this.ShawBox.Size = new System.Drawing.Size(65, 65);
            this.ShawBox.TabIndex = 9;
            this.ShawBox.Visible = false;
            this.ShawBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.characterBox_RightClick);
            this.ShawBox.Click += new System.EventHandler(this.ShawBox_Click);
            this.ShawBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseDown);
            this.ShawBox.MouseHover += new System.EventHandler(this.characterBox_MouseHover);
            this.ShawBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseMove);
            this.ShawBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.characterBox_MouseUp);
            // 
            // shawCDTimer
            // 
            this.shawCDTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shawCDTimer.AutoSize = true;
            this.shawCDTimer.Location = new System.Drawing.Point(15, 45);
            this.shawCDTimer.Name = "shawCDTimer";
            this.shawCDTimer.Size = new System.Drawing.Size(35, 13);
            this.shawCDTimer.TabIndex = 5;
            this.shawCDTimer.Text = "label2";
            this.shawCDTimer.Visible = false;
            this.shawCDTimer.Click += new System.EventHandler(this.ShawBox_Click);
            this.shawCDTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // shawHP
            // 
            this.shawHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shawHP.AutoSize = true;
            this.shawHP.Location = new System.Drawing.Point(14, 29);
            this.shawHP.Name = "shawHP";
            this.shawHP.Size = new System.Drawing.Size(35, 13);
            this.shawHP.TabIndex = 4;
            this.shawHP.Text = "label1";
            this.shawHP.Visible = false;
            this.shawHP.Click += new System.EventHandler(this.ShawBox_Click);
            this.shawHP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // shawCostLabel
            // 
            this.shawCostLabel.Location = new System.Drawing.Point(23, 35);
            this.shawCostLabel.Name = "shawCostLabel";
            this.shawCostLabel.Size = new System.Drawing.Size(19, 13);
            this.shawCostLabel.TabIndex = 1;
            this.shawCostLabel.Text = "19";
            this.shawCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shawCostLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // shawNameLabel
            // 
            this.shawNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shawNameLabel.AutoSize = true;
            this.shawNameLabel.Location = new System.Drawing.Point(15, 12);
            this.shawNameLabel.Name = "shawNameLabel";
            this.shawNameLabel.Size = new System.Drawing.Size(34, 13);
            this.shawNameLabel.TabIndex = 0;
            this.shawNameLabel.Text = "Shaw";
            this.shawNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shawNameLabel.Click += new System.EventHandler(this.ShawBox_Click);
            this.shawNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxLabel_RightClick);
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointLabel.Location = new System.Drawing.Point(702, 276);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(27, 20);
            this.pointLabel.TabIndex = 3;
            this.pointLabel.Text = "30";
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.Location = new System.Drawing.Point(3, 276);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(51, 20);
            this.livesLabel.TabIndex = 2;
            this.livesLabel.Text = "label1";
            // 
            // gameGrid
            // 
            this.gameGrid.AllowDrop = true;
            this.gameGrid.BackColor = System.Drawing.Color.White;
            this.gameGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gameGrid.ColumnCount = 11;
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.gameGrid.Location = new System.Drawing.Point(3, 73);
            this.gameGrid.Margin = new System.Windows.Forms.Padding(0);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.RowCount = 3;
            this.gameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.gameGrid.Size = new System.Drawing.Size(727, 199);
            this.gameGrid.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.characterSelectionPanel);
            this.Controls.Add(this.launchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.characterSelectionPanel.ResumeLayout(false);
            this.characterSelectionPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.characterQueuePanel.ResumeLayout(false);
            this.CardiganBox.ResumeLayout(false);
            this.CardiganBox.PerformLayout();
            this.MyrtleBox.ResumeLayout(false);
            this.MyrtleBox.PerformLayout();
            this.MelanthaBox.ResumeLayout(false);
            this.MelanthaBox.PerformLayout();
            this.ShawBox.ResumeLayout(false);
            this.ShawBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Panel characterSelectionPanel;
        private System.Windows.Forms.CheckBox shawCheckBox;
        private System.Windows.Forms.CheckBox melanthaCheckBox;
        private System.Windows.Forms.CheckBox myrtleCheckBox;
        private System.Windows.Forms.CheckBox cardiganCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label characterSelectionPrompt;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.TableLayoutPanel gameGrid;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.FlowLayoutPanel characterQueuePanel;
        private System.Windows.Forms.Panel CardiganBox;
        private System.Windows.Forms.Label cardiganCostLabel;
        private System.Windows.Forms.Label cardiganNameLabel;
        private System.Windows.Forms.Panel MyrtleBox;
        private System.Windows.Forms.Label myrtleCostLabel;
        private System.Windows.Forms.Label myrtleNameLabel;
        private System.Windows.Forms.Panel MelanthaBox;
        private System.Windows.Forms.Label melanthaCostLabel;
        private System.Windows.Forms.Label melanthaNameLabel;
        private System.Windows.Forms.Panel ShawBox;
        private System.Windows.Forms.Label shawCostLabel;
        private System.Windows.Forms.Label shawNameLabel;
        private System.Windows.Forms.Label cardiganCDTimer;
        private System.Windows.Forms.Label cardiganHP;
        private System.Windows.Forms.Label myrtleCDTimer;
        private System.Windows.Forms.Label myrtleHP;
        private System.Windows.Forms.Label melanthaCDTimer;
        private System.Windows.Forms.Label melanthaHP;
        private System.Windows.Forms.Label shawCDTimer;
        private System.Windows.Forms.Label shawHP;
        private System.Windows.Forms.Label characterStats;
    }
}

