using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74126343_practice_3_2
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> loginInfo = new Dictionary<string, string>();
        List<(int orderNum, int orderQuantity, string orderProduct, string user)> orderHistory = new List<(int orderNum, int orderQuantity, string orderProduct, string user)>();
        string selectedProduct;
        string currentUser;
        int orderNumber = 1000;
        public Form1()
        {
            loginInfo.Add("admin", "admin");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            welcomePanel = new Panel();
            loginPanel = new Panel();
            orderPanel = new Panel();
            */
        }
        private void openButton_Click(object sender, EventArgs e)
        {
            broadcastText.Text = "Welcome! Please log in!";
            openButton.Visible = false;

            usernameLabel.Visible = true;
            passwordLabel.Visible = true;
            usernameBox.Visible = true;
            passwordBox.Visible = true;
            loginButton.Visible = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usernameInput = usernameBox.Text;
            string passwordInput = passwordBox.Text;
            usernameBox.Clear();
            passwordBox.Clear();

            if (loginInfo.ContainsKey(usernameInput) && loginInfo[usernameInput] == passwordInput)
            {
                usernameLabel.Visible = false;
                passwordLabel.Visible = false;
                usernameBox.Visible = false;
                passwordBox.Visible = false;
                loginButton.Visible = false;

                broadcastText.Text = $"Welcome, {usernameInput}";
                currentUser = usernameInput;
                newOrderButton.Visible = true;
                listOrderButton.Visible = true;
                newAccButton.Visible = true;
                logOutButton.Visible = true;
                listOrderBox.Visible = true;

            }
            else
            {
                broadcastText.Text = "Wrong Username or Password";
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            broadcastText.Text = "輸入完數量後，點選對應的商品按鈕，並按送出";
            listOrderBox.Clear();
            newOrderButton.Visible = false;
            listOrderButton.Visible = false;
            listOrderBox.Visible = false;
            newAccButton.Visible = false;
            logOutButton.Visible = false;

            quantityLabel.Visible = true;
            quantityBox.Visible = true;
            penguinButton.Visible = true;
            tonkatsuButton.Visible = true;
            shrimpButton.Visible = true;
            placeOrderButton.Visible = true;
        }

        private void listOrderButton_Click(object sender, EventArgs e)
        {
            listOrderBox.Clear();
            foreach (var order in orderHistory)
            {
                listOrderBox.Text += ($"訂單編號: {order.orderNum} 購買了 {order.orderQuantity} 個 {order.orderProduct}，此訂單由{order.user}新增" + Environment.NewLine);
            }
        }

        private void penguinButton_Click(object sender, EventArgs e)
        {
            selectedProduct = "企鵝";
            penguinButton.Text = "企鵝(已選擇)";
            tonkatsuButton.Text = "炸豬排";
            shrimpButton.Text = "炸蝦";
        }

        private void tonkatsuButton_Click(object sender, EventArgs e)
        {
            selectedProduct = "炸豬排";
            penguinButton.Text = "企鵝";
            tonkatsuButton.Text = "炸豬排(已選擇)";
            shrimpButton.Text = "炸蝦";
        }

        private void shrimpButton_Click(object sender, EventArgs e)
        {
            selectedProduct = "炸蝦";
            penguinButton.Text = "企鵝";
            tonkatsuButton.Text = "炸豬排";
            shrimpButton.Text = "炸蝦(已選擇)";
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            int quantity;

            if (selectedProduct == null)
            {
                broadcastText.Text = "請選擇商品";
            }
            else if (!int.TryParse(quantityBox.Text, out quantity) || quantity <= 0)
            {
                broadcastText.Text = "請輸入正整數";
            }
            else
            {
                orderHistory.Add((orderNumber, quantity, selectedProduct, currentUser));
                penguinButton.Text = "企鵝";
                tonkatsuButton.Text = "炸豬排";
                shrimpButton.Text = "炸蝦";
                selectedProduct = null;
                broadcastText.Text = "新增訂單成功，訂單編號" + orderNumber;
                orderNumber++;

                quantityBox.Clear();
                newOrderButton.Visible = true;
                listOrderButton.Visible = true;
                listOrderBox.Visible = true;
                newAccButton.Visible = true;
                logOutButton.Visible = true;
                listOrderBox.Clear();

                quantityLabel.Visible = false;
                quantityBox.Visible = false;
                penguinButton.Visible = false;
                tonkatsuButton.Visible = false;
                shrimpButton.Visible = false;
                placeOrderButton.Visible = false;
            }
        }

        private void newAccButton_Click(object sender, EventArgs e)
        {
            broadcastText.Text = "請輸入要新增的使用者帳號與密碼";
            newOrderButton.Visible = false;
            listOrderButton.Visible = false;
            listOrderBox.Visible = false;
            newAccButton.Visible = false;
            logOutButton.Visible = false;
            listOrderBox.Clear();

            usernameLabel.Visible = true;
            passwordLabel.Visible = true;
            usernameBox.Visible = true;
            passwordBox.Visible = true;
            createButton.Visible = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string newUsername = usernameBox.Text;
            string newPassword = passwordBox.Text;

            if (newUsername == "")
            {
                broadcastText.Text = "請輸入新增使用者帳號";
            }
            else if (newPassword == "")
            {
                broadcastText.Text = "請輸入新增使用者密碼";
            }
            else if (loginInfo.ContainsKey(newUsername))
            {
                broadcastText.Text = "此使用者已存在";
                usernameBox.Clear();
                passwordBox.Clear();
            }
            else
            {
                loginInfo.Add(newUsername, newPassword);
                usernameBox.Clear();
                passwordBox.Clear();
                usernameLabel.Visible = false;
                passwordLabel.Visible = false;
                usernameBox.Visible = false;
                passwordBox.Visible = false;
                createButton.Visible = false;

                broadcastText.Text = $"Welcome, {newUsername}";
                currentUser = newUsername;
                newOrderButton.Visible = true;
                listOrderButton.Visible = true;
                newAccButton.Visible = true;
                logOutButton.Visible = true;
                listOrderBox.Visible = true;
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            broadcastText.Text = "Welcome! Please log in!";
            currentUser = null;
            listOrderBox.Clear();
            newOrderButton.Visible = false;
            listOrderButton.Visible = false;
            listOrderBox.Visible = false;
            newAccButton.Visible = false;
            logOutButton.Visible = false;

            usernameLabel.Visible = true;
            passwordLabel.Visible = true;
            usernameBox.Visible = true;
            passwordBox.Visible = true;
            loginButton.Visible = true;
        }
    }
}
