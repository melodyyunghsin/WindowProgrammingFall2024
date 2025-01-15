using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static F74126343_practice_5_2.Form1;

namespace F74126343_practice_5_2
{

    public partial class Form1 : Form
    {
        int playerLives = 3;
        int enemiesLeft = 10;
        int playerPoints = 30;
        Timer pointTimer = new Timer();
        Timer deployEnemyTimer = new Timer();
        Timer EnemyTimer = new Timer();
        Character Cardigan = new Character("Cardigan", 2130, 305, 475, 18, 20);
        Character Myrtle = new Character("Myrtle", 1565, 520, 300, 10, 22);
        Character Melantha = new Character("Melantha", 2745, 738, 155, 15, 40);
        Character Shaw = new Character("Shaw", 1785, 580, 365, 19, 5);
        bool mouseDown = false;
        Point startLocation = new Point();
        int panelStartLocation;
        Panel selectedPanel = new Panel();
        Panel gameOver = new Panel();
        Panel playerBase = new Panel();
        int enemyTickCount = 0;

        List<Enemy> existingEnemy = new List<Enemy>();
        List <Panel> characterPanel = new List<Panel>();
        List<string> selectedCharacters = new List<string>();

        public Form1()
        {
            gameOver.Visible = false;
            gameOver.Size = new Size(732, 409);
            this.Controls.Add(gameOver);
            gameOver.Location = new Point(0, 1);

            InitializeComponent();
            InitializeGameGrid();

            pointTimer.Interval = 1000;
            pointTimer.Tick += PointTimer_Tick;
            deployEnemyTimer.Interval = 7500;
            deployEnemyTimer.Tick += deployEnemyTimer_Tick;
            EnemyTimer.Tick += EnemyTimer_Tick;
            EnemyTimer.Interval = 20;
            

            Cardigan.cooldownTimer.Interval = 1000;
            Cardigan.cooldownTimer.Tick += CardiganTimer_Tick;
            Myrtle.cooldownTimer.Interval = 1000;
            Myrtle.cooldownTimer.Tick += MyrtleTimer_Tick;
            Melantha.cooldownTimer.Interval = 1000;
            Melantha.cooldownTimer.Tick += MelanthaTimer_Tick;
            Shaw.cooldownTimer.Interval = 1000;
            Shaw.cooldownTimer.Tick += ShawTimer_Tick;
        }
        
        
        private void CoolDownTimer_Tick(Character character, Label timerLabel, Panel characterPanel)
        {
            if (character.deployed && character.CDTime > 0)
            {
                character.CDTime -= 1;
                timerLabel.Text = $"{character.CDTime}";
            }
            if (character.deployed && character.CDTime == 0)
            {
                character.CDTime = 0;
                characterPanel.BackColor = Color.LimeGreen;
            }
        }
        private void CardiganTimer_Tick(object sender, EventArgs e)
        {
            CoolDownTimer_Tick(Cardigan, cardiganCDTimer, CardiganBox);
        }
        private void MyrtleTimer_Tick(object sender, EventArgs e)
        {
            CoolDownTimer_Tick(Myrtle, myrtleCDTimer, MyrtleBox);
        }
        private void MelanthaTimer_Tick(object sender, EventArgs e)
        {
            CoolDownTimer_Tick(Melantha, melanthaCDTimer, MelanthaBox);
        }
        private void ShawTimer_Tick(object sender, EventArgs e)
        {
            CoolDownTimer_Tick(Shaw, shawCDTimer, ShawBox);
        }

        private void EnemyTimer_Tick (object sender, EventArgs e)
        {
            enemyTickCount++;
            if(existingEnemy.Count != 0)
            {
                foreach (var enemy in existingEnemy.ToList())
                {
                    Panel box = enemy.enemyBox;
                    //Point boxLocation = gameGrid.PointToClient(new Point(box.Left, box.Top));
                    Point boxLocation = gameGrid.PointToClient(enemy.Location);
                    bool onCharacter = false;
                    foreach (var characterBox in characterPanel)
                    {
                        string characterName = characterBox.Name.Replace("Box", "");
                        Character character = getCharacter(characterName);

                        //if(enemyTickCount % 50 == 0) //MessageBox.Show($"{box.Top}/{characterBox.Top}");


                        if (character.deployed && box.Right - 15 > characterBox.Left && box.Left < characterBox.Right && box.Top > (characterBox.Parent.Parent.Top + characterBox.Parent.Top + characterBox.Top) && box.Bottom < (characterBox.Parent.Parent.Top + characterBox.Parent.Top + characterBox.Bottom))
                        {
                            enemy.moveTimer.Stop();
                            if (enemyTickCount % 25 == 0) attack(enemy, character, characterName, characterBox);
                            onCharacter = true;
                        }
                        else if (character.deployed && box.Right > characterBox.Left && box.Left < characterBox.Right)
                        {
                            if (enemyTickCount % 25 == 0) attack(enemy, character, characterName, characterBox);
                        }
                        else if (box.Right - 15 > 664 && box.Visible)
                        {
                            killedEnemy(enemy);
                            playerLives--;
                            livesLabel.Text = $"{playerLives} / {enemiesLeft}";
                            //MessageBox.Show($"{playerLives}");
                            if (playerLives == 0)
                            {
                                gamePanel.Visible = false;
                                Label gameOverLabel = new Label();
                                gameOverLabel.AutoSize = true;
                                gameOverLabel.Text = "Game Over. You Lost!";
                                gameOver.Controls.Add(gameOverLabel);
                                gameOverLabel.Visible = true;
                                gameOverLabel.BringToFront();
                                gameOverLabel.ForeColor = Color.Black;
                                gameOverLabel.BackColor = Color.Transparent;
                                gameOverLabel.Location = new Point(gameOver.Width / 2 - gameOverLabel.Width / 2, gameOver.Height / 2 - gameOverLabel.Height / 2);
                                gameOver.Visible = true;
                            }
                            
                        }
                    }
                    if (!onCharacter) enemy.moveTimer.Start();

                }
            }
            
        }
        private void attack(Enemy enemy, Character character, string characterName, Panel box)
        {
            enemy.curHP -= character.ATK - enemy.DEF;
            character.curHP -= enemy.ATK - character.DEF;
            if (enemy.curHP <= 0)
            {
                killedEnemy(enemy);
                enemiesLeft--;
                if (enemiesLeft <= 0)
                {
                    gamePanel.Visible = false;
                    Label gameOverLabel = new Label();
                    gameOverLabel.Text = "Game Over. You Win!";
                    gameOver.Controls.Add(gameOverLabel);
                    gameOverLabel.AutoSize = true;
                    gameOverLabel.Visible = true;
                    gameOverLabel.BringToFront();
                    gameOverLabel.ForeColor = Color.Black;
                    gameOverLabel.BackColor = Color.Transparent;
                    gameOverLabel.Location = new Point(gameOver.Width / 2 - gameOverLabel.Width / 2, gameOver.Height / 2 - gameOverLabel.Height / 2);
                    gameOver.Visible = true;
                }
                livesLabel.Text = $"{playerLives} / {enemiesLeft}";
            }
            if(character.curHP <= 0)
            {
                retreat(box, character);
            }
            Label characterHP = characterHPLabel(characterName);
            characterHP.Text = $"{character.curHP}/{character.HP}";
            characterHP.Location = new Point((box.Width - characterHP.Width) / 2, characterHP.Location.Y);
            enemy.enemyHPLabel.Text = $"{enemy.curHP}";
            enemy.enemyHPLabel.Location = new Point((enemy.enemyBox.Width - enemy.enemyHPLabel.Width) / 2, enemy.enemyHPLabel.Location.Y);
        }
        private void killedEnemy(Enemy enemy)
        {
            gameGrid.Controls.Remove(enemy.enemyBox);
            enemy.enemyBox.Dispose();
            existingEnemy.Remove(enemy);
        }

        private bool IsCharacterBox(Panel box)
        {
            return box == CardiganBox || box == MyrtleBox || box == MelanthaBox || box == ShawBox;
        }
        private void deployEnemyTimer_Tick(object sender, EventArgs e)
        {
            Enemy newEnemy = new Enemy();
            //newEnemy.spawnEnemy();
            existingEnemy.Add(newEnemy);
            gamePanel.Controls.Add(newEnemy.enemyBox);
            newEnemy.enemyBox.BringToFront();
            newEnemy.enemyHPLabel.BringToFront();
            //MessageBox.Show("new enemyyy");
            Point enemyBoxLocation = new Point(newEnemy.enemyBox.Left, newEnemy.enemyBox.Top); 
            //MessageBox.Show($"{newEnemy.enemyBox.Location}/{enemyBoxLocation}/{gameGrid.PointToClient(enemyBoxLocation)}");
        }
        private void PointTimer_Tick(object sender, EventArgs e)
        {
            if (playerPoints < 99)
            {
                playerPoints += 1;
                pointLabel.Text = $"{playerPoints}";
            }
        }

        private void InitializeGameGrid()
        {
            for (int row = 0; row < gameGrid.RowCount; row++)
            {
                for (int col = 0; col < gameGrid.ColumnCount; col++)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(65, 65);
                    panel.Margin = new Padding(0);
                    panel.Padding = new Padding(0);
                    panel.BackColor = Color.White;
                    gameGrid.Controls.Add(panel, col, row);
                }
            }

            gameGrid.GetControlFromPosition(0, 1).BackColor = Color.Red;
            gameGrid.GetControlFromPosition(10, 1).BackColor = Color.Blue;
            playerBase = (Panel)gameGrid.GetControlFromPosition(10, 1);

            livesLabel.Text = $"{playerLives} / {enemiesLeft}";
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            launchButton.Visible = false;
            characterSelectionPanel.Visible = true;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            if (cardiganCheckBox.Checked || myrtleCheckBox.Checked || melanthaCheckBox.Checked || shawCheckBox.Checked)
            {
                characterSelectionPanel.Visible = false;
                gamePanel.Visible = true;
                if (cardiganCheckBox.Checked) selectedCharacters.Add("Cardigan");
                if (myrtleCheckBox.Checked) selectedCharacters.Add("Myrtle");
                if (melanthaCheckBox.Checked) selectedCharacters.Add("Melantha");
                if (shawCheckBox.Checked) selectedCharacters.Add("Shaw");
                foreach (var characterName in selectedCharacters)
                {
                    if (characterName == "Cardigan")
                    {
                        CardiganBox.Visible = true;
                        characterPanel.Add(CardiganBox);
                    }
                    else if (characterName == "Myrtle")
                    {
                        MyrtleBox.Visible = true;
                        characterPanel.Add(MyrtleBox);
                    }
                    else if (characterName == "Melantha")
                    {
                        MelanthaBox.Visible = true;
                        characterPanel.Add(MelanthaBox);
                    }
                    else if (characterName == "Shaw")
                    {
                        ShawBox.Visible = true;
                        characterPanel.Add(ShawBox);
                    }
                }


                //gamePanel.BringToFront();
                pointTimer.Start();
                deployEnemyTimer.Start();
                EnemyTimer.Start();
            }
        }

        private Character getCharacter(string name)
        {
            if (name == "Cardigan") return Cardigan;
            else if (name == "Myrtle") return Myrtle;
            else if (name == "Melantha") return Melantha;
            else if (name == "Shaw") return Shaw;
            else return null;
        }
        private void characterBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedPanel = sender as Panel;
                if (selectedPanel.Parent == characterQueuePanel)
                {
                    mouseDown = true;
                    characterQueuePanel.SuspendLayout();
                    panelStartLocation = characterQueuePanel.Controls.GetChildIndex(selectedPanel);
                    startLocation = e.Location;
                    selectedPanel.BringToFront();

                    selectedPanel.Parent = this;
                    selectedPanel.BringToFront();
                }

            }
        }

        private void characterBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && selectedPanel != null)
            {
                Point panelLocation = selectedPanel.Location;
                panelLocation.X += e.X - startLocation.X;
                panelLocation.Y += e.Y - startLocation.Y;

                selectedPanel.Location = panelLocation;
            }
        }
        
        private Label characterCostLabel(string characterName)
        {
            if (characterName == "Cardigan")
            {
                return cardiganCostLabel;
            }
            else if (characterName == "Myrtle")
            {
                return myrtleCostLabel;
            }
            else if (characterName == "Melantha")
            {
                return melanthaCostLabel;
            }
            else if (characterName == "Shaw")
            {
                return shawCostLabel;
            }
            else return null;
        }
        private Label characterHPLabel(string characterName)
        {
            if (characterName == "Cardigan")
            {
                return cardiganHP;
            }
            else if (characterName == "Myrtle")
            {
                return myrtleHP;
            }
            else if (characterName == "Melantha")
            {
                return melanthaHP;
            }
            else if (characterName == "Shaw")
            {
                return shawHP;
            }
            else return null;
        }
        private Label characterTimerLabel(string characterName)
        {
            if (characterName == "Cardigan")
            {
                return cardiganCDTimer;
            }
            else if (characterName == "Myrtle")
            {
                return myrtleCDTimer;
            }
            else if (characterName == "Melantha")
            {
                return melanthaCDTimer;
            }
            else if (characterName == "Shaw")
            {
                return shawCDTimer;
            }
            else return null;
        }
        private int getCharacterCost(string name)
        {
            if (name == "Cardigan") return Cardigan.Cost;
            else if (name == "Myrtle") return Myrtle.Cost;
            else if (name == "Melantha") return Melantha.Cost;
            else if (name == "Shaw") return Shaw.Cost;
            else return -1;
        }
        private void characterBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseDown = false;
                Point dropLocation = gameGrid.PointToClient(Cursor.Position);
                string characterName = selectedPanel.Name.Replace("Box", "");
                int characterCost = getCharacterCost(characterName);
                //MessageBox.Show($"Drop Location: {dropLocation}\nCharacter Cost: {characterCost}\nPlayer Points: {playerPoints}");
                if (characterCost > playerPoints || dropLocation.X > 727 || dropLocation.Y > 199 || dropLocation.X < 0 || dropLocation.Y < 0)
                {
                    characterQueuePanel.Controls.Add(selectedPanel);
                    characterQueuePanel.Controls.SetChildIndex(selectedPanel, panelStartLocation);
                }
                else
                {
                    TableLayoutPanelCellPosition cellPosition = gameGrid.GetCellPosition(gameGrid.GetChildAtPoint(dropLocation));
                    if (gameGrid.GetControlFromPosition(cellPosition.Column, cellPosition.Row).BackColor != Color.White)
                    {
                        characterQueuePanel.Controls.Add(selectedPanel);
                        characterQueuePanel.Controls.SetChildIndex(selectedPanel, panelStartLocation);
                    }
                    else if (cellPosition.Row >= 0 && cellPosition.Column >= 0)
                    {
                        gameGrid.Controls.Remove(gameGrid.GetControlFromPosition(cellPosition.Column, cellPosition.Row));
                        gameGrid.Controls.Add(selectedPanel, cellPosition.Column, cellPosition.Row);

                        deployCharacter(characterName, selectedPanel);
                        playerPoints -= characterCost;
                        pointLabel.Text = $"{playerPoints}";

                    }
                }

                characterQueuePanel.ResumeLayout();
            }
        }

        private void deployCharacter(string characterName, Panel characterPanel)
        {
            characterPanel.BackColor = Color.DarkGray;
            Label costLabel = new Label();
            Label hpLabel = new Label();
            Label timerLabel = new Label();
            int fullHP = 0, currentHP = 0, characterTimer = 0;
            if (characterName == "Cardigan")
            {
                costLabel = cardiganCostLabel;
                hpLabel = cardiganHP;
                timerLabel = cardiganCDTimer;
                fullHP = Cardigan.HP;
                currentHP = Cardigan.curHP;
                characterTimer = Cardigan.CDTime;
                Cardigan.deployed = true;
                Cardigan.cooldownTimer.Start();

            }
            else if (characterName == "Myrtle")
            {
                costLabel = myrtleCostLabel;
                hpLabel = myrtleHP;
                timerLabel = myrtleCDTimer;
                fullHP = Myrtle.HP;
                currentHP = Myrtle.curHP;
                characterTimer = Myrtle.CDTime;
                Myrtle.deployed = true;
                Myrtle.cooldownTimer.Start();
            }
            else if (characterName == "Melantha")
            {
                costLabel = melanthaCostLabel;
                hpLabel = melanthaHP;
                timerLabel = melanthaCDTimer;
                fullHP = Melantha.HP;
                currentHP = Melantha.curHP;
                characterTimer = Melantha.CDTime;
                Melantha.deployed = true;
                Melantha.cooldownTimer.Start();
            }
            else if (characterName == "Shaw")
            {
                costLabel = shawCostLabel;
                hpLabel = shawHP;
                timerLabel = shawCDTimer;
                fullHP = Shaw.HP;
                currentHP = Shaw.curHP;
                characterTimer = Shaw.CDTime;
                Shaw.deployed = true;
                Shaw.cooldownTimer.Start();
            }

            costLabel.Visible = false;
            hpLabel.Visible = true;
            timerLabel.Visible = true;
            hpLabel.Text = $"{currentHP}/{fullHP}";
            timerLabel.Text = characterTimer.ToString();
            int x_hp = (characterPanel.Width - hpLabel.Width) / 2;
            int y_hp = hpLabel.Location.Y;
            int x_cd = (characterPanel.Width - timerLabel.Width) / 2;
            int y_cd = timerLabel.Location.Y;
            hpLabel.Location = new Point(x_hp, y_hp);
            timerLabel.Location = new Point(x_cd, y_cd);
        }
        
        private void characterBox_MouseHover(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            string characterName = panel.Name.Replace("Box", "");
            Character character = getCharacter(characterName);
            if (character.deployed)
            {
                characterStats.Text = $"{character.Name}\n{character.curHP}/{character.HP}\n{character.CDTime}";
                characterStats.Location = new Point(722 - characterStats.Width, 19);
                characterStats.Visible = true;
            }  
        }
        private void retreat(Panel characterBox, Character character)
        {
            string characterName = characterBox.Name.Replace("Box", "");
            TableLayoutPanelCellPosition cellPosition = gameGrid.GetCellPosition(characterBox);
            characterQueuePanel.Controls.Add(characterBox);
            characterBox.BackColor = Color.White;
            Label costLabel = characterCostLabel(characterName);
            Label hpLabel = characterHPLabel(characterName);
            Label timerLabel = characterTimerLabel(characterName);
            character.curHP = character.HP;
            character.CDTime = character.CD;
            character.deployed = false;
            character.cooldownTimer.Stop();
            costLabel.Visible = true;
            hpLabel.Visible = false;
            timerLabel.Visible = false;
            Panel panel = new Panel();
            panel.Size = new Size(65, 65);
            panel.Margin = new Padding(0);
            panel.Padding = new Padding(0);
            panel.BackColor = Color.White;
            gameGrid.Controls.Add(panel, cellPosition.Column, cellPosition.Row);
        }

        private void boxLabel_RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Label clickedLabel = (Label)sender;
                Panel clickedPanel = (Panel)clickedLabel.Parent;
                string characterName = clickedPanel.Name.Replace("Box", "");
                Character character = getCharacter(characterName);
                if (character.deployed)
                {
                    retreat(clickedPanel, character);
                }
            }
            
        }
        private void characterBox_RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Panel characterBox = sender as Panel;
                string characterName = characterBox.Name.Replace("Box", "");
                Character character = getCharacter(characterName);
                if (character.deployed)
                {
                    retreat(characterBox, character);
                }
            }
            

        }

        private void CardiganBox_Click(object sender, EventArgs e)
        {
            if (Cardigan.deployed && Cardigan.CDTime == 0)
            {
                Cardigan.curHP = (int)(Cardigan.curHP * 1.4);
                if (Cardigan.curHP > Cardigan.HP) Cardigan.curHP = Cardigan.HP;
                cardiganHP.Text = $"{Cardigan.curHP}/{Cardigan.HP}";
                Cardigan.CDTime = Cardigan.CD;
                CardiganBox.BackColor = Color.DarkGray;
            }
        }
        private void MyrtleBox_Click(object sender, EventArgs e)
        {
            if (Myrtle.deployed && Myrtle.CDTime == 0)
            {
                playerPoints += 14;
                pointLabel.Text = "${playerPoints}";
                Myrtle.CDTime = Myrtle.CD;
                MyrtleBox.BackColor = Color.DarkGray;

            }
        }
        private void MelanthaBox_Click(object sender, EventArgs e)
        {
            if (Melantha.deployed && Melantha.CDTime == 0)
            {
                foreach (var enemy in existingEnemy.ToList())
                {
                    Panel box = enemy.enemyBox;

                    if (box.Right > MelanthaBox.Left - 65 && box.Top > (MelanthaBox.Parent.Parent.Top + MelanthaBox.Parent.Top + MelanthaBox.Top) && box.Bottom < (MelanthaBox.Parent.Parent.Top + MelanthaBox.Parent.Top + MelanthaBox.Bottom))
                    {
                        Melantha.ATK = Melantha.ATK * 2;
                        attack(enemy, Melantha, "melantha", MelanthaBox);
                        Melantha.ATK /= 2;
                        Melantha.CDTime = Melantha.CD;
                        MelanthaBox.BackColor = Color.DarkGray;

                        break;
                    }
                }
                
            }
        }
        private void ShawBox_Click(object sender, EventArgs e)
        {
            if (Shaw.deployed && Shaw.CDTime == 0)
            {
                foreach (var enemy in existingEnemy.ToList())
                {
                    Panel box = enemy.enemyBox;

                    if (box.Right > ShawBox.Left - 65)
                    {
                        box.Location = new Point(box.Location.X - 65, box.Location.Y);
                        Shaw.CDTime = Shaw.CD;
                        ShawBox.BackColor = Color.DarkGray;
                        break;
                    }
                }
            }
        }
    }
    public class Character
    {
        public string Name;
        public int curHP;
        public int HP;
        public int ATK;
        public int DEF;
        public int Cost;
        public int CDTime;
        public int CD;
        public bool deployed = false;
        public Timer cooldownTimer = new Timer();

        public Character(string name, int hP, int aTK, int dEF, int cost, int cDTime)
        {
            Name = name;
            curHP = hP;
            HP = hP;
            ATK = aTK;
            DEF = dEF;
            Cost = cost;
            CDTime = cDTime;
            CD = cDTime;
        }
    }
    public class Enemy
    {
        public int curHP = 1500;
        public int HP = 1500;
        public int ATK = 600;
        public int DEF = 300;
        public Panel enemyBox = new Panel();
        public Label enemyHPLabel = new Label();
        public bool onCharacter = false;
        public Timer moveTimer = new Timer();
        public Point Location = new Point();
        public Enemy()
        {
            enemyHPLabel.Text = curHP.ToString();
            enemyHPLabel.AutoSize = true;
            enemyHPLabel.Visible = true;
            enemyHPLabel.BringToFront();


            enemyBox.Size = new Size(30, 30);
            enemyBox.Location = new Point(3, 158);
            Location = enemyBox.Location;
            enemyBox.Tag = "Enemy";
            enemyBox.BackColor = Color.Yellow;
            enemyBox.Visible = true;
            enemyBox.Controls.Add(enemyHPLabel);
            enemyHPLabel.Location = new Point(15 - (enemyHPLabel.Width / 2), 15 - (enemyHPLabel.Height / 2));
            enemyHPLabel.BackColor = Color.Transparent;
            enemyHPLabel.ForeColor = Color.Black;
            enemyBox.BringToFront();

            moveTimer.Start();
            moveTimer.Interval = 20;
            moveTimer.Tick += moveTimer_Tick;
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            enemyBox.Location = new Point(Location.X + 2, Location.Y);
            Location = enemyBox.Location;
            //checkAttack();
        }
    }
}
    
