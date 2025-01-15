using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace F74126343_practice_3_1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> loginInfo = new Dictionary<string, string>();
        List<(int orderNum, int orderQuantity, string orderProduct)> orderHistory = new List<(int orderNum, int orderQuantity, string orderProduct)>();
        string selectedProduct;
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

                broadcastText.Text = "Welcome, admin";
                newOrderButton.Visible = true;
                listOrderButton.Visible = true;
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
            newOrderButton.Visible = false;
            listOrderButton.Visible = false;
            listOrderBox.Visible = false;

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
                listOrderBox.Text += ($"訂單編號: {order.orderNum} 購買了 {order.orderQuantity} 個 {order.orderProduct}" + Environment.NewLine);
            }
        }

        private void penguinButton_Click(object sender, EventArgs e)
        {
            selectedProduct = "企鵝";
        }

        private void tonkatsuButton_Click(object sender, EventArgs e)
        {
            selectedProduct = "炸豬排";
        }

        private void shrimpButton_Click(object sender, EventArgs e)
        {
            selectedProduct = "炸蝦";
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            int quantity;
            
            if (selectedProduct == null)
            {
                broadcastText.Text = "請選擇商品";
            }
            else if(!int.TryParse(quantityBox.Text, out quantity) || quantity <= 0)
            {
                broadcastText.Text = "請輸入正整數";
            }
            else
            {
                orderHistory.Add((orderNumber, quantity, selectedProduct));
                selectedProduct = null;
                broadcastText.Text = "新增訂單成功，訂單編號" + orderNumber;
                orderNumber++;

                quantityBox.Clear();
                newOrderButton.Visible = true;
                listOrderButton.Visible = true;
                listOrderBox.Visible = true;
                listOrderBox.Clear();

                quantityLabel.Visible = false;
                quantityBox.Visible = false;
                penguinButton.Visible = false;
                tonkatsuButton.Visible = false;
                shrimpButton.Visible = false;
                placeOrderButton.Visible = false;
            }
        }
    }
}
