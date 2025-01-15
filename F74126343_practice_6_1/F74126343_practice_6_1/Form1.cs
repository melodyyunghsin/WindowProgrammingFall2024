using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace F74126343_practice_6_1
{
    public partial class Form1 : Form
    {
        int blockWidth = 50;
        int blockHeight = 50;
        int columns = 30;
        int rows = 15;
        Block.BlockType selectedType = Block.BlockType.DIRT;
        Block[,] blocks = new Block[30, 15];
        bool gameStart = false;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            gamePanel.Visible = false;
            landscapePanel.MouseClick += landscapePanel_MouseClick;
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = landscapePanel.Height - viewPanel.Height;
            vScrollBar1.SmallChange = blockHeight;
            //vScrollBar1.LargeChange = blockHeight * rows - viewPanel.Height;

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = landscapePanel.Width - viewPanel.Width;
            hScrollBar1.SmallChange = blockHeight;
            //hScrollBar1.LargeChange = blockHeight * rows - viewPanel.Height;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Vector2F position = new Vector2F(i, j);
                    Block newBlock;
                    if (j >= 10) newBlock = new Block(position, Block.BlockType.STONE);
                    else if (j < 10 && j >= 8)
                    {
                        newBlock = new Block(position, Block.BlockType.DIRT);
                    }
                    else if (j == 7)
                    {
                        if (i / 5 == 2 || i / 5 == 4) newBlock = new Block(position, Block.BlockType.DIRT);
                        else newBlock = new Block(position, Block.BlockType.GRASS_BLOCK);
                    }
                    else if (j == 6)
                    {
                        if (i / 5 == 2 || i / 5 == 4) newBlock = new Block(position, Block.BlockType.GRASS_BLOCK);
                        else continue; 
                    }
                    else continue;
                    blocks[i, j] = newBlock;
                }
            }
        }

        private void landscapePanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point blockLocation = new Point(e.X, e.Y);
            if(sender.GetType() == typeof(PictureBox))
            {
                PictureBox pictureBox = (PictureBox)sender;
                blockLocation = pictureBox.Location;
            }
            Vector2F selectedLocation = new Vector2F(blockLocation.X / blockWidth, blockLocation.Y / blockHeight);
            //MessageBox.Show($"{selectedLocation.X}/{selectedLocation.Y}");
            if (e.Button == MouseButtons.Right)
            {
                Block newBlock = new Block(selectedLocation, selectedType);
                if (blocks[selectedLocation.X, selectedLocation.Y] == null)
                {
                    blocks[selectedLocation.X, selectedLocation.Y] = newBlock;
                    placeBlock(newBlock);
                }
            }
            else if(e.Button == MouseButtons.Left)
            {
                Block deleteBlock = blocks[selectedLocation.X, selectedLocation.Y];
                if(deleteBlock != null)
                {
                    //MessageBox.Show("deleting");
                    deleteBlock.Picture.Visible = false;
                    deleteBlock.Picture.Dispose();
                    landscapePanel.Controls.Remove(deleteBlock.Picture);
                    blocks[selectedLocation.X, selectedLocation.Y] = null;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameStart = true;
            startPanel.Visible = false;
            gamePanel.Visible = true;
            viewPanel.Visible = true;
            landscapePanel.Visible = true;
            vScrollBar1.Visible = true;
            hScrollBar1.Visible = true;
            viewPanel.AutoScroll = false;
            landscapePanel.AutoScroll = false;
            vScrollBar1.BringToFront();
            hScrollBar1.BringToFront();

            CreateTerritory();
            steve.Location = new Point(0, blocks[0, 7].Position.Y * blockHeight - steve.Height);
        }

        private void CreateTerritory()
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Block getBlock = blocks[i,j];
                    if (getBlock == null) continue;
                    placeBlock(getBlock);
                }
            }
        }

        private void placeBlock(Block block)
        {
            block.Picture.Location = new Point(block.Position.X * blockWidth, block.Position.Y * blockHeight);
            landscapePanel.Controls.Add(block.Picture);
            block.Picture.Visible = true;
            block.Picture.MouseClick += landscapePanel_MouseClick;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameStart && e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D9)
            {
                if (e.KeyCode == Keys.D1) selectedType = Block.BlockType.DIRT;
                else if (e.KeyCode == Keys.D2) selectedType = Block.BlockType.GRASS_BLOCK;
                else if (e.KeyCode == Keys.D3) selectedType = Block.BlockType.STONE;
                else if (e.KeyCode == Keys.D4) selectedType = Block.BlockType.WATER;
                int selectedSlot = e.KeyCode - Keys.D1;
                selectedFrame.Location = new Point(selectedSlot * 47, 0);
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int x = landscapePanel.Location.X;
            int y = -vScrollBar1.Value;
            landscapePanel.Location = new Point(x, y);   
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int x = -hScrollBar1.Value;
            int y = landscapePanel.Location.Y;
            landscapePanel.Location = new Point(x, y);
        }
    }
    public class Vector2F
    {
        int x, y;
        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }
        public Vector2F(int x_val, int y_val)
        {
            x = x_val;
            y = y_val;
        }
    }
    public class Block
    {
        public readonly Vector2F Position;
        public readonly BlockType Type;
        public PictureBox Picture;

        public enum BlockType
        {
            WATER,
            GRASS_BLOCK,
            DIRT,
            STONE,
        }

        public Block(Vector2F position, BlockType type)
        {
            Position = position;
            Type = type;
            Picture = new PictureBox();
            Picture.Size = new Size(50, 50);
            Picture.SizeMode = PictureBoxSizeMode.Zoom;
            Picture.Padding = new Padding(0);
            Picture.Margin = new Padding(0);
            if (Type == BlockType.WATER) Picture.Image = Properties.Resources.Water;
            else if(Type == BlockType.GRASS_BLOCK) Picture.Image = Properties.Resources.GrassDirt;
            else if(Type == BlockType.DIRT) Picture.Image = Properties.Resources.Dirt;
            else if(Type == BlockType.STONE) Picture.Image = Properties.Resources.Stone;
        }
    }

}
