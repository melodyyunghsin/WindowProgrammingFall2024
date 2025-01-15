using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74126343_practice_7_2
{
    public partial class Form3 : Form
    {
        private TextBox textbox;
        private int startIndex = 0;
        string lookupText;
        private Form searchForm;
        public bool isReplaceText = false;
        public Form3(ref TextBox textBox)
        {
            InitializeComponent();
            this.textbox = textBox;
        }

        private void findNextButton_Click(object sender, EventArgs e)
        {
            if(lookupText == null || lookupText != findTextBox.Text)
            {
                lookupText = findTextBox.Text;
                startIndex = 0;
            }
            
            if (string.IsNullOrEmpty(lookupText))
            {
                MessageBox.Show("請輸入要尋找的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = textbox.Text.IndexOf(lookupText, startIndex);
                if (index >= 0)
                {
                    textbox.Select(index, lookupText.Length);
                    startIndex = index + lookupText.Length;
                    textbox.Focus();
                    //Application.DoEvents();
                }
                else
                {
                    MessageBox.Show("已找不到匹配項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    startIndex = 0;
                }

            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string replaceText = replaceTextBox.Text;
            if (lookupText == null || lookupText != findTextBox.Text)
            {
                lookupText = findTextBox.Text;
                startIndex = 0;
            }
            if (string.IsNullOrEmpty(replaceText))
            {
                MessageBox.Show("請輸入要取代的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(lookupText))
            {
                MessageBox.Show("請輸入要尋找的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textbox.SelectedText))
            {
                MessageBox.Show("請輸入要尋找的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*
                int index = textbox.Text.IndexOf(lookupText, startIndex);
                if (index >= 0)
                {
                    textbox.Select(index, lookupText.Length);
                    startIndex = index + lookupText.Length;
                    textbox.Focus();
                    this.Owner.Activate();
                    this.Owner.Focus();
                }
                else
                {
                    MessageBox.Show("已找不到匹配項目", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    startIndex = 0;
                }
                textbox.SelectedText = replaceText;
                */
                startIndex = 0;
                
            }
            else
            {
                isReplaceText = true;
                textbox.SelectedText = replaceText;
                isReplaceText = false;
                if(this.Owner is Form2 parentForm)
                {
                    parentForm.undo.Pop();
                }
                int index = textbox.Text.IndexOf(lookupText, startIndex);
                if (index >= 0)
                {
                    textbox.Select(index, lookupText.Length);
                    startIndex = index + lookupText.Length;
                    textbox.Focus();
                    //Application.DoEvents();
                }
                this.Owner.Activate();
                this.Owner.Focus();
            }
        }

        private void replaceAllButton_Click(object sender, EventArgs e)
        {
            string replaceText = replaceTextBox.Text;
            if (lookupText == null || lookupText != findTextBox.Text)
            {
                lookupText = findTextBox.Text;
                startIndex = 0;
            }
            if (string.IsNullOrEmpty(replaceText))
            {
                MessageBox.Show("請輸入要取代的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(lookupText))
            {
                MessageBox.Show("請輸入要尋找的文字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textbox.Text = textbox.Text.Replace(lookupText, replaceText);
                //searchForm.Activate();
            }
        }

    }
}
