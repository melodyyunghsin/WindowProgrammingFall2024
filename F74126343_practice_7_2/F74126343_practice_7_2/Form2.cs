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
using System.Runtime.Remoting.Messaging;

namespace F74126343_practice_7_2
{
    public partial class Form2 : Form
    {
        public string currentFilePath = null;
        public bool mytxt = false;
        public string fileContent;
        public myTxt file = new myTxt();
        private Timer saveTimer = new Timer();
        public Stack<myTxt> undo = new Stack<myTxt>();
        //private Stack<myTxt> redo = new Stack<myTxt>();
        private bool userChange = true;
        private myTxt lastEdit;
        private string lastText = "";
        private string addedText;
        private string lastAction;
       
        private int temp = 0;
        public Form2()
        {
            InitializeComponent();
            
            saveTimer.Interval = 60000;
            saveTimer.Tick += SaveTimer_Tick;
            saveTimer.Start();
        }

        public void initStack()
        {
            getCurrentText();
        }
        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            if (currentFilePath != null)
            {
                saveFile(currentFilePath, mytxt);
            }
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
                //File.Delete(filePath);
                file.Text = fileContentDisplay.Text;
                file.Font = fileContentDisplay.Font;
                file.FontColor = fileContentDisplay.ForeColor;
                //File.Copy(filePath, fileContentDisplay.Text);
                File.WriteAllText(filePath, file.Text);
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
                getCurrentText();
            }
        }

        private void colorMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                fileContentDisplay.ForeColor = colorDialog.Color;
                getCurrentText();
            }
        }

        private void endMenuButton_Click(object sender, EventArgs e)
        {
            if(!checkBackUp())
            {
                var result = MessageBox.Show("檔案尚未儲存，是否確定要關閉?","未儲存的變更", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void formClosing_Check(object sender, FormClosingEventArgs e)
        {
            if (!checkBackUp())
            {
                var result = MessageBox.Show("檔案尚未儲存，是否確定要關閉?", "未儲存的變更", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }

        private bool checkBackUp()
        {
            if (currentFilePath == null) return false;
            if (fileContentDisplay.Text != file.Text) return false;
            if (fileContentDisplay.Font != file.Font) return false;
            if (fileContentDisplay.ForeColor != file.FontColor) return false;
            return true;
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            if(fileContentDisplay.SelectedText.Length > 0)
            {
                fileContentDisplay.Cut();
                addedText = null;
            }
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            if (fileContentDisplay.SelectedText.Length > 0)
            {
                fileContentDisplay.Copy();
                addedText = null;
            }
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                fileContentDisplay.Paste();
                addedText = Clipboard.GetText();
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

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userChange = false;
            if (undo.Count() == 0)
            {
                userChange = true;
                return;
            }
            myTxt undoText = undo.Pop();
            if (fileContentDisplay.Text == undoText.Text && fileContentDisplay.Font == undoText.Font && fileContentDisplay.ForeColor == undoText.FontColor)
            {
                if (undo.Count() == 0)
                {
                    undo.Push(undoText);
                    userChange = true;
                    return;
                }
                undoText = undo.Pop();
            }
            fileContentDisplay.Text = undoText.Text;
            fileContentDisplay.Font = undoText.Font;
            fileContentDisplay.ForeColor = undoText.FontColor;
            userChange = true;
            lastEdit = undoText;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(addedText);
            if (!string.IsNullOrEmpty(addedText))
            {
                fileContentDisplay.Text = fileContentDisplay.Text.Insert(fileContentDisplay.SelectionStart, addedText); 
                //fileContentDisplay.SelectionStart += addedText.Length;
            }
        }
        private void fileContentDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                addedText = null;
                addedText += e.KeyChar;
                //MessageBox.Show(addedText);
            }
        }
        private void wordCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] allword = fileContentDisplay.Text.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = 0;
            foreach (string w in allword)
            {
                wordCount += w.Length;
            }

            MessageBox.Show($"字數統計:{wordCount}", "字數", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        private void findReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 findReplaceform = new Form3(ref fileContentDisplay);
            findReplaceform.Owner = this;
            findReplaceform.Show();
        }

        private void FileContentDisplay_TextChanged(object sender, System.EventArgs e)
        {
            if (lastText == null) lastText = fileContentDisplay.Text;
            //MessageBox.Show("Text Changed");
            getCurrentText();
            lastText = fileContentDisplay.Text;
        }

        private void getCurrentText()
        {
            myTxt currentText = new myTxt();
            currentText.Text = fileContentDisplay.Text;
            currentText.Font = fileContentDisplay.Font;
            currentText.FontColor = fileContentDisplay.ForeColor;
            undo.Push(currentText);
            if (currentText.Text.Length <= lastText.Length)
            {
                addedText = null;
                //MessageBox.Show($"addedText = null/{currentText.Text}/{lastText}");
            }
            //MessageBox.Show("Text Changed");
        }
    }

    public class myTxt
    {
        public string Text { get; set; }
        public Font Font { get; set; }
        public Color FontColor { get; set; }
        //public float FontSize { get; set; }
        //public FontStyle FontStyle { get; set; }
    }
}
