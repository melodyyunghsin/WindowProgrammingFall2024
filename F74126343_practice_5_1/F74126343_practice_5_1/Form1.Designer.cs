namespace F74126343_practice_5_1
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
            this.plate = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plate)).BeginInit();
            this.SuspendLayout();
            // 
            // plate
            // 
            this.plate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.plate.BackColor = System.Drawing.Color.Red;
            this.plate.Location = new System.Drawing.Point(335, 431);
            this.plate.Name = "plate";
            this.plate.Size = new System.Drawing.Size(70, 10);
            this.plate.TabIndex = 0;
            this.plate.TabStop = false;
            this.plate.Visible = false;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(246, 210);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(237, 83);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "label1";
            this.scoreLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 489);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.plate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.plate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox plate;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label scoreLabel;
    }
}

