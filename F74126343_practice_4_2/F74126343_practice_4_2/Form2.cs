using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74126343_practice_4_2
{
    public partial class stickerForm : Form
    {
        public Image selectedSticker;
        public stickerForm()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            radioButton4.CheckedChanged += RadioButton_CheckedChanged;
            radioButton5.CheckedChanged += RadioButton_CheckedChanged;
            radioButton6.CheckedChanged += RadioButton_CheckedChanged;
        }


        private void uncheckAll()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is RadioButton radioButton && radioButton != rb)
                    {
                        radioButton.Checked = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) selectedSticker = Properties.Resources._0;
            else if (radioButton2.Checked) selectedSticker = Properties.Resources._1;
            else if (radioButton3.Checked) selectedSticker = Properties.Resources._2;
            else if (radioButton4.Checked) selectedSticker = Properties.Resources._3;
            else if (radioButton5.Checked) selectedSticker = Properties.Resources._4;
            else if (radioButton6.Checked) selectedSticker = Properties.Resources._5;
            
            if (selectedSticker != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.Text = "Please select a sticker";
            }
        }
    }
}
