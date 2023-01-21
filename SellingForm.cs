using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;


namespace Minimarket_Managment
{
    public partial class SellingForm : Form
    {
        DBConnect dBCon = new DBConnect();
        DGVPrinter printer = new DGVPrinter();
        
        public SellingForm()
        {
            InitializeComponent();
        }
        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_Category.DataSource = table;
            comboBox_Category.ValueMember = "CatName";

        }
        private void getTable()
        {
            string selectQuerry = "SELECT ProdName, ProdPrice FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Product.DataSource = table;
        }
        private void getSellTable()
        {
            string selectQuerry = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_SellList.DataSource = table;
        }



        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_Date.Text = DateTime.Today.ToShortDateString();
            label_Seller.Text = Form1.NameEmploye;
            getTable();
            getCategory();
            getSellTable();
        }

        private void dataGridView_Product_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = dataGridView_Product.SelectedRows[0].Cells[0].Value.ToString();
            textBox_Price.Text = dataGridView_Product.SelectedRows[0].Cells[1].Value.ToString();
        }
        int grandTotal = 0, n = 0;

        private void comboBox_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT ProdName, ProdPrice FROM Product WHERE ProdCat='" + comboBox_Category.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Product.DataSource = table;
        }

        private void button_AddtoBill_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES(" + textBox_IdtoBill.Text + ",'" + label_Seller.Text + "','" + label_Date.Text + "'," + grandTotal.ToString() + ")";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getSellTable();
                clear();
                    


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            printer.Title = "Sekuy MiniMarket Sell Lists";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "SEKUYTEAM";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_SellList);
        }

        

        private void button_AddOrder_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || textBox_Quantity.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int Total = Convert.ToInt32(textBox_Price.Text) * Convert.ToInt32(textBox_Quantity.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_Order);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = textBox_Name.Text;
                addRow.Cells[2].Value = textBox_Price.Text;
                addRow.Cells[3].Value = textBox_Quantity.Text;
                addRow.Cells[4].Value = Total;
                dataGridView_Order.Rows.Add(addRow);
                grandTotal += Total;
                label_Amount.Text = grandTotal + " ";
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_IdtoBill.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Bill WHERE BillId =" + textBox_IdtoBill.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            getSellTable();
           
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button_Selling_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void button_Category_Click(object sender, EventArgs e)
        {
            EmployeForm employe = new EmployeForm();
            employe.Show();
            this.Hide();
        }

        private void button_Product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void dataGridView_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_Order.Rows.Clear();
        }

     

        private void clear()
        {
            textBox_IdtoBill.Clear();
            textBox_Price.Clear();
            textBox_Quantity.Clear();
            
          
        }
    }
}
