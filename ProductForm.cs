using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Minimarket_Managment
{
    public partial class ProductForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button_Category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
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
            comboBox_Search.DataSource = table;
            comboBox_Search.ValueMember = "CatName";
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Product.DataSource = table;
        }
        private void clear()
        {
            textBox_Id.Clear();
            textBox_Name.Clear();
            textBox_Price.Clear();
            textBox_Quantity.Clear();
            comboBox_Category.SelectedIndex = 0;
        }

        private void dataGridView_Product_Click(object sender, EventArgs e)
        {
            textBox_Id.Text = dataGridView_Product.SelectedRows[0].Cells[0].Value.ToString();
            textBox_Name.Text = dataGridView_Product.SelectedRows[0].Cells[1].Value.ToString();
            textBox_Price.Text = dataGridView_Product.SelectedRows[0].Cells[2].Value.ToString();
            textBox_Quantity.Text = dataGridView_Product.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_Category.SelectedValue = dataGridView_Product.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_Id.Text == "" || textBox_Quantity.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string insertQuery = "INSERT INTO Product VALUES(" + textBox_Id.Text + ",'" + textBox_Name.Text + "'," + textBox_Price.Text + "," + textBox_Quantity.Text + ",'" + comboBox_Category.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Id.Text == "" || textBox_Name.Text == "" || textBox_Price.Text == "" || textBox_Quantity.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string updateQuery = "UPDATE Product SET ProdName='" + textBox_Name.Text + "',ProdPrice=" + textBox_Price.Text + ",ProdQty=" + textBox_Quantity.Text + ",ProdCat='" + comboBox_Category.Text + "'WHERE ProdId=" + textBox_Id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Id.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Product WHERE ProdId=" + textBox_Id.Text + "";
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
            getTable();
        }

        private void comboBox_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT * FROM Product WHERE ProdCat='" + comboBox_Search.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Product.DataSource = table;
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Employe_Click(object sender, EventArgs e)
        {
            EmployeForm employe = new EmployeForm();
            employe.Show();
            this.Hide();
        }

        private void button_Selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        
    }
}
