using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace F74126343_practice_7_1
{
    public partial class Form2 : Form
    {
        public string currentFilePath = null;
        public bool mytxt = false;
        public string fileContent;
        public myTxt file = new myTxt();

        public Form2()
        {
            InitializeComponent();
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilePath != null)
            {
                saveFile(currentFilePath, mytxt);
            }
            else
            {
                saveAs();
            }
            
        }

        private void saveNewMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveAs()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                mytxt = currentFilePath.EndsWith(".mytxt");

                saveFile(currentFilePath, mytxt);
                this.Text = currentFilePath; 
            }
        }

        private void saveFile(string filePath, bool isMyTxt)
        {
            if(!isMyTxt)
            {
                File.Delete(filePath);
                //File.Copy(fileContentDisplay.Text, filePath);
                File.WriteAllText(filePath, fileContentDisplay.Text);
            }
            else
            {
                file.Text = fileContentDisplay.Text;
                file.Font = fileContentDisplay.Font;
                file.FontColor = fileContentDisplay.ForeColor;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"{file.Font.FontFamily.Name}");
                    writer.WriteLine($"{file.Font.Size}");
                    writer.WriteLine($"{file.Font.Style}");
                    writer.WriteLine($"{file.FontColor.ToArgb():X8}");
                    writer.Write(file.Text);
                }
            }
        }

        private void fontMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fileContentDisplay.Font = fontDialog.Font;
            }
        }

        private void colorMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                fileContentDisplay.ForeColor = colorDialog.Color;
            }
        }

        private void endMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            if(fileContentDisplay.SelectedText.Length > 0)
            {
                fileContentDisplay.Cut();
            }
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            if (fileContentDisplay.SelectedText.Length > 0)
            {
                fileContentDisplay.Copy();
            }
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                fileContentDisplay.Paste();
            }
        }

        public void openMyTxt(string path)
        {
            string fontName = "";
            float fontSize = 8;
            FontStyle fontStyle = FontStyle.Regular;
            Color textColor = Color.Black;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                for(int i = 0; i < 4; i++) 
                {
                    line = reader.ReadLine();
                    if (i == 0)
                        fontName = line.Trim();
                    else if (i == 1)
                        fontSize = float.Parse(line.Trim());
                    else if (i == 2)
                        fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), line.Trim());
                    else if (i == 3)
                        textColor = Color.FromArgb(int.Parse(line.Trim(), System.Globalization.NumberStyles.HexNumber));
                }
                file.Text = reader.ReadToEnd();
                file.Font = new Font(fontName, fontSize, fontStyle);
                file.FontColor = textColor;

                fileContentDisplay.Text = file.Text;
                fileContentDisplay.Font = file.Font;
                fileContentDisplay.ForeColor = file.FontColor;
            }
        }

    }

    public class myTxt
    {
        public string Text { get; set; }
        public Font Font { get; set; }
        public Color FontColor { get; set; }
        public float FontSize { get; set; }
        public FontStyle FontStyle { get; set; }
    }
}
