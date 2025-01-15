using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74126343_practice_7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void fileMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void endMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent;

                Form2 newForm = new Form2();
                newForm.MdiParent = this;
                newForm.Name = filePath;
                newForm.currentFilePath = filePath;
                if (filePath.EndsWith(".mytxt"))
                {
                    newForm.mytxt = true;
                    newForm.openMyTxt(filePath);
                }
                else
                {
                    fileContent = File.ReadAllText(filePath);
                    newForm.fileContentDisplay.Text = fileContent;
                    newForm.fileContentDisplay.Visible = true;
                }
                
                //newForm.fileContentDisplay.AutoSize = true;
                newForm.Show();
            }
        }
    }
}
