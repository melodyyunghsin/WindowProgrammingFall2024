using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74126343_Homework8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'f74126343_dbDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.f74126343_dbDataSet1.Customers);
            // TODO: This line of code loads data into the 'f74126343_dbDataSet1.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.f74126343_dbDataSet1.Items);
            // TODO: This line of code loads data into the 'f74126343_dbDataSet1.TransactionHistory' table. You can move, or remove it, as needed.
            this.transactionHistoryTableAdapter.Fill(this.f74126343_dbDataSet1.TransactionHistory);

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
