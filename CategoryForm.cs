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
    public partial class CategoryForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Category.DataSource = table;
        }

        private void dataGridView_Category_Click(object sender, EventArgs e)
        {
            textBox_Id.Text = dataGridView_Category.SelectedRows[0].Cells[1].Value.ToString();
            textBox_Name.Text = dataGridView_Category.SelectedRows[0].Cells[1].Value.ToString();
            textBox_Description.Text = dataGridView_Category.SelectedRows[0].Cells[2].Value.ToString();
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + textBox_Id.Text + ",'" + textBox_Name.Text + "','" + textBox_Description.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Id.Text == "" || textBox_Name.Text == "" || textBox_Description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Category SET CatName='" + textBox_Name.Text + "', CatDesc='" + textBox_Description.Text + "'WHERE CatId=" + textBox_Id.Text + " ";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        private void clear()
        {
            textBox_Id.Clear();
            textBox_Name.Clear();
            textBox_Description.Clear();
        }

      

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_Id.Text == "" )
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string deleteQuery = "DELETE FROM Category WHERE CatId=" + textBox_Id.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button_Product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
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
