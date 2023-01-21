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
    public partial class EmployeForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public EmployeForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Employe";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Employe.DataSource = table;
        }
        private void clear()
        {
            textBox_Idemploye.Clear();
            textBox_Nameemploye.Clear();
            textBox_Age.Clear();
            textBox_Nohp.Clear();
       

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Employe VALUES(" + textBox_Idemploye.Text + ",'" + textBox_Nameemploye.Text + "','" + textBox_Age.Text + "','" + textBox_Nohp.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Employe Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeForm_Load(object sender, EventArgs e)
        {
            getTable();
        }


        private void dataGridView_Employe_Click(object sender, EventArgs e)
        {
            textBox_Idemploye.Text = dataGridView_Employe.SelectedRows[0].Cells[0].Value.ToString();
            textBox_Nameemploye.Text = dataGridView_Employe.SelectedRows[0].Cells[1].Value.ToString();
            textBox_Age.Text = dataGridView_Employe.SelectedRows[0].Cells[2].Value.ToString();
            textBox_Nohp.Text = dataGridView_Employe.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Idemploye.Text == "" || textBox_Nameemploye.Text == "" || textBox_Age.Text == "" || textBox_Nohp.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string updateQuery = "UPDATE Employe SET EmployeName=" + textBox_Nameemploye.Text + "',EmployeAge='" + textBox_Age.Text + "',EmployePhone='" + textBox_Nohp.Text + "'WHERE EmployeId='" + textBox_Idemploye.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Employe Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (textBox_Idemploye.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Employe WHERE IdEmploye=" + textBox_Idemploye.Text + "";
                        SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                        dBCon.OpenCon();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Employe Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dBCon.CloseCon();
                        getTable();
                        clear();
                    }
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

        private void button_Product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button_Selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

       
    }
}
