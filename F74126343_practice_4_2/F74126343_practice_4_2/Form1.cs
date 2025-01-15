using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace F74126343_practice_4_2
{

    public partial class Form1 : Form
    {
        List<(string sender, string textMessage)> pastMessages = new List<(string sender, string textMessage)>();
        bool user = true;
        bool game = false;
        private Form colorForm;
        //private Form stickerForm;
        private Image sticker;
        private Color selectedColor;
        Image dogPfp = Properties.Resources.dog;
        Image catPfp = Properties.Resources.cat;

        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += SwitchUser;
            tabPage1.DoubleClick += OpenColorForm;
            tabPage2.DoubleClick += OpenColorForm;
            chatRoom1.DoubleClick += OpenColorForm;
            chatRoom2.DoubleClick += OpenColorForm;
            
        }

        
        private void newMessage(string message, bool user)
        {
            Label textLabel1 = new Label();
            Label textLabel2 = new Label();
            textLabel1.MaximumSize = new Size(200, 0);
            textLabel2.MaximumSize = new Size(200, 0);
            
            textLabel1.Text = message;
            textLabel2.Text = message;

            textLabel1.AutoSize = true;
            textLabel2.AutoSize = true;
            textLabel1.TextAlign = ContentAlignment.TopLeft;
            textLabel2.TextAlign = ContentAlignment.TopLeft;

            Image Pfp;
            if (user) Pfp = dogPfp;
            else Pfp = catPfp;

            FlowLayoutPanel newMessagePanel1 = new FlowLayoutPanel();
            FlowLayoutPanel newMessagePanel2 = new FlowLayoutPanel();

            newMessagePanel1.FlowDirection = FlowDirection.RightToLeft;
            newMessagePanel1.Size = new Size(467, 0);
            newMessagePanel1.MinimumSize = new Size(467, 0);
            newMessagePanel1.AutoSizeMode = AutoSizeMode.GrowOnly;
            newMessagePanel1.AutoSize = true;
            newMessagePanel1.WrapContents = false;

            newMessagePanel2.FlowDirection = FlowDirection.LeftToRight;
            newMessagePanel2.Size = new Size(467, 0);
            newMessagePanel2.MinimumSize = new Size(467, 0);
            newMessagePanel2.AutoSizeMode = AutoSizeMode.GrowOnly;
            newMessagePanel2.AutoSize = true;
            newMessagePanel2.WrapContents = false;
            


            PictureBox profilePictureBox1 = new PictureBox();
            profilePictureBox1.Image = Pfp;
            profilePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            profilePictureBox1.Size = new Size(13, 13);
            PictureBox profilePictureBox2 = new PictureBox();
            profilePictureBox2.Image = Pfp;
            profilePictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            profilePictureBox2.Size = new Size(13, 13);

            newMessagePanel1.Controls.Add(textLabel1);
            newMessagePanel1.Controls.Add(profilePictureBox1);

            newMessagePanel2.Controls.Add(profilePictureBox2);
            newMessagePanel2.Controls.Add(textLabel2);

            if(user)
            {
                chatRoom1.Controls.Add(newMessagePanel1);
                chatRoom1.ScrollControlIntoView(newMessagePanel1);
                chatRoom2.Controls.Add(newMessagePanel2);
                chatRoom2.ScrollControlIntoView(newMessagePanel2);
            }
            else
            {
                chatRoom1.Controls.Add(newMessagePanel2);
                chatRoom1.ScrollControlIntoView(newMessagePanel2);
                chatRoom2.Controls.Add(newMessagePanel1);
                chatRoom2.ScrollControlIntoView(newMessagePanel1);
            }

        }
        private void SwitchUser(object sender, EventArgs e)
        {
            user = tabControl1.SelectedIndex == 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            textBox1.Clear();
            
            if (game && (message == "剪刀" || message == "石頭" || message == "布"))
            {
                newMessage("斗哥: " + message, user);
                Random rand = new Random();
                string play = null;
                while(play == null)
                {
                    int choice = rand.Next(1, 4);
                    if (choice == 1) play = "剪刀";
                    else if (choice == 2) play = "石頭";
                    else if (choice == 3) play = "布";
                }
                 
                user = false;
                newMessage("楷特: " + play, user);
                user = true;
                game = false;
                button2.Enabled = true;
                textBox2.Enabled = true;
                stickerButton2.Enabled = true;
            }
            else if (!game)
            {
                newMessage("斗哥: " + message, user);
                if (message == "猜拳")
                {
                    user = false;
                    newMessage("楷特: 遊戲開始", user);
                    user = true;
                    button2.Enabled = false;
                    textBox2.Enabled = false;
                    stickerButton2.Enabled = false;
                    game = true;
                }
                else if (message == "汪!")
                {
                    user = false;
                    newMessage("楷特: 喵", user);
                    user = true;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = textBox2.Text;
            textBox2.Clear();
            newMessage("楷特: " + message, user);
            if (message == "喵!")
            {
                user = true;
                newMessage("斗哥: 汪", user);
                user = false;
            }
        }

        private void colorChange(object sender, EventArgs e)
        {
            if (user)
            {
                tabPage1.BackColor = selectedColor;
                chatRoom1.BackColor = selectedColor;
            }
            else
            {
                tabPage2.BackColor = selectedColor;
                chatRoom2.BackColor = selectedColor;
            }

            colorForm.Close();
            colorForm = null;
        }

        private void newColor(object sender, EventArgs e)
        {
            Random rand = new Random();
            selectedColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            colorForm.BackColor = selectedColor;
        }
        private void OpenColorForm(object sender, EventArgs e)
        {
            if (colorForm == null)
            {
                colorForm = new Form
                {
                    Size = new Size(400, 400),
                };
                Random rand = new Random();
                selectedColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                colorForm.BackColor = selectedColor;
                Button okButton = new Button { Text = "OK", Dock = DockStyle.Bottom };
                okButton.Click += colorChange;

                colorForm.Click += newColor;

                colorForm.Controls.Add(okButton);
                colorForm.Show();
            }
        }

        private void sendSticker(string message, bool user, Image sticker)
        {
            Label textLabel1 = new Label();
            Label textLabel2 = new Label();
            textLabel1.MaximumSize = new Size(200, 0);
            textLabel2.MaximumSize = new Size(200, 0);

            textLabel1.Text = message;
            textLabel2.Text = message;

            textLabel1.AutoSize = true;
            textLabel2.AutoSize = true;
            textLabel1.TextAlign = ContentAlignment.TopLeft;
            textLabel2.TextAlign = ContentAlignment.TopLeft;

            Image Pfp;
            if (user) Pfp = dogPfp;
            else Pfp = catPfp;

            FlowLayoutPanel newMessagePanel1 = new FlowLayoutPanel();
            FlowLayoutPanel newMessagePanel2 = new FlowLayoutPanel();

            newMessagePanel1.FlowDirection = FlowDirection.RightToLeft;
            newMessagePanel1.Size = new Size(467, 0);
            newMessagePanel1.MinimumSize = new Size(467, 0);
            newMessagePanel1.AutoSizeMode = AutoSizeMode.GrowOnly;
            newMessagePanel1.AutoSize = true;
            newMessagePanel1.WrapContents = false;

            newMessagePanel2.FlowDirection = FlowDirection.LeftToRight;
            newMessagePanel2.Size = new Size(467, 0);
            newMessagePanel2.MinimumSize = new Size(467, 0);
            newMessagePanel2.AutoSizeMode = AutoSizeMode.GrowOnly;
            newMessagePanel2.AutoSize = true;
            newMessagePanel2.WrapContents = false;

            PictureBox stickerBox1 = new PictureBox();
            stickerBox1.Image = sticker;
            stickerBox1.SizeMode = PictureBoxSizeMode.Zoom;
            stickerBox1.Size = new Size(15, 15);
            PictureBox stickerBox2 = new PictureBox();
            stickerBox2.Image = sticker;
            stickerBox2.SizeMode = PictureBoxSizeMode.Zoom;
            stickerBox2.Size = new Size(15, 15);

            PictureBox profilePictureBox1 = new PictureBox();
            profilePictureBox1.Image = Pfp;
            profilePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            profilePictureBox1.Size = new Size(13, 13);
            PictureBox profilePictureBox2 = new PictureBox();
            profilePictureBox2.Image = Pfp;
            profilePictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            profilePictureBox2.Size = new Size(13, 13);

            newMessagePanel1.Controls.Add(stickerBox1);
            newMessagePanel1.Controls.Add(textLabel1);
            newMessagePanel1.Controls.Add(profilePictureBox1);

            newMessagePanel2.Controls.Add(profilePictureBox2);
            newMessagePanel2.Controls.Add(textLabel2);
            newMessagePanel2.Controls.Add(stickerBox2);

            if (user)
            {
                chatRoom1.Controls.Add(newMessagePanel1);
                chatRoom1.ScrollControlIntoView(newMessagePanel1);
                chatRoom2.Controls.Add(newMessagePanel2);
                chatRoom2.ScrollControlIntoView(newMessagePanel2);
            }
            else
            {
                chatRoom1.Controls.Add(newMessagePanel2);
                chatRoom1.ScrollControlIntoView(newMessagePanel2);
                chatRoom2.Controls.Add(newMessagePanel1);
                chatRoom2.ScrollControlIntoView(newMessagePanel1);
            }

        }

        private void stickerButton1_Click(object sender, EventArgs e)
        {
            stickerForm stickerForm = new stickerForm();
            if (stickerForm.ShowDialog() == DialogResult.OK)
            {
                sticker = stickerForm.selectedSticker;
            }
            sendSticker("斗哥: ", user, sticker);
        }

        private void stickerButton2_Click(object sender, EventArgs e)
        {
            stickerForm stickerForm = new stickerForm();
            if (stickerForm.ShowDialog() == DialogResult.OK)
            {
                sticker = stickerForm.selectedSticker;
            }
            sendSticker("楷哥: ", user, sticker);
        }
    }

}
