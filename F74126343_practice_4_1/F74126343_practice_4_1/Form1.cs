using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace F74126343_practice_4_1
{
    
    public partial class Form1 : Form
    {
        List<(string sender, string textMessage)> pastMessages = new List<(string sender, string textMessage)>();
        bool user = true;
        private Form colorForm;
        private Color selectedColor;

        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += SwitchUser;
            tabPage1.DoubleClick += OpenColorForm;
            tabPage2.DoubleClick += OpenColorForm;
            chatRoom1.DoubleClick += OpenColorForm;
            chatRoom2.DoubleClick += OpenColorForm;

        }

        private void SwitchUser(object sender, EventArgs e)
        {
            user = tabControl1.SelectedIndex == 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textAlignLeft(RichTextBox box, string text)
        {
            box.SelectionAlignment = HorizontalAlignment.Left;
            box.AppendText(text);
        }
        private void textAlignRight(RichTextBox box, string text)
        {
            
            box.SelectionAlignment = HorizontalAlignment.Right;
            box.AppendText(text);
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

            FlowLayoutPanel newMessagePanel1 = new FlowLayoutPanel();
            FlowLayoutPanel newMessagePanel2 = new FlowLayoutPanel();

            newMessagePanel1.FlowDirection = FlowDirection.RightToLeft;
            newMessagePanel1.Size = new Size(460, 0);
            newMessagePanel1.MinimumSize = new Size(460, 0);
            newMessagePanel1.AutoSizeMode = AutoSizeMode.GrowOnly;
            newMessagePanel1.AutoSize = true;
            newMessagePanel1.WrapContents = false;
            newMessagePanel1.Controls.Add(textLabel1);

            newMessagePanel2.FlowDirection = FlowDirection.LeftToRight;
            newMessagePanel2.Size = new Size(460, 0);
            newMessagePanel2.MinimumSize = new Size(460, 0);
            newMessagePanel2.AutoSizeMode = AutoSizeMode.GrowOnly;
            newMessagePanel2.AutoSize = true;
            newMessagePanel2.WrapContents = false;
            newMessagePanel2.Controls.Add(textLabel2);

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

        private void button2_Click(object sender, EventArgs e)
        {
            string message = textBox2.Text;
            textBox2.Clear();
            newMessage($"楷特: {message}", user);
            user = true;
            newMessage("斗哥: Woof!", user);
            user = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            

        }
        private void colorChange(object sender, EventArgs e)
        {
            if (user)
            {
                tabPage1.BackColor = selectedColor;
                //panel1.BackColor = Color.Transparent;
                //chatRoom1.Enabled = true;
                chatRoom1.BackColor = selectedColor;
                //chatRoom1.Enabled = false;
            }
            else
            {
                tabPage2.BackColor = selectedColor;
                //panel2.BackColor = Color.Transparent;
                //chatRoom2.Enabled = true;
                chatRoom2.BackColor = selectedColor;
                //chatRoom2.Enabled = false;
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
        


    }

}
