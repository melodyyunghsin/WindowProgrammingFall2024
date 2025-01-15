using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74126343_practice_5_1
{
    public partial class Form1 : Form
    {
        private int speed = 10;
        private int fruitDropped = 0;
        private int fruitCaught = 0;
        private Random random = new Random();
        private Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            scoreLabel.Text = $"{fruitCaught}/{fruitDropped}";
            timer.Tick += fruitDrop;
            timer.Interval = 30;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            plate.Visible = true;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(plate_Control);
            timer.Start();
            scoreLabel.Visible = true;
        }

        private void plate_Control(object sender, KeyEventArgs e)
        {
            if (e.Shift) speed = 20;
            else speed = 10;

            if (plate.Location.X >= 0 && (e.KeyCode == Keys.Left || e.KeyCode == Keys.A))
            {
                plate.Left -= speed;
            }
            else if (plate.Location.X <= this.Width - plate.Width  && (e.KeyCode == Keys.Right || e.KeyCode == Keys.D))
            {
                plate.Left += speed;
            }
        }

        private void fruitDrop (object sender, EventArgs e)
        {
            if(random.Next(0,50) < 5)
            {
                PictureBox fruit = new PictureBox();
                int imageNum = random.Next(0, 2);
                if (imageNum == 1) fruit.Image = Properties.Resources.g1;
                else fruit.Image = Properties.Resources.g2;
                fruit.Size = new Size(50, 50);
                fruit.SizeMode = PictureBoxSizeMode.Zoom;
                fruit.Top = 0;
                fruit.Left = random.Next(0, this.Width - fruit.Width);
                this.Controls.Add(fruit);
                fruit.Tag = "fruit";
            }
            

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag?.ToString() == "fruit")
                {
                    PictureBox fruits = (PictureBox)control;
                    fruits.Top += 10;

                    if (fruits.Top >= this.Height)
                    {
                        this.Controls.Remove(fruits);
                        fruitDropped++;
                        scoreLabel.Text = $"{fruitCaught}/{fruitDropped}";
                    }

                    if (fruits.Bounds.IntersectsWith(plate.Bounds))
                    {
                        this.Controls.Remove(fruits);
                        fruitCaught++;
                        fruitDropped++; scoreLabel.Text = $"{fruitCaught}/{fruitDropped}";

                    }
                }
            }
        }
    }
}
