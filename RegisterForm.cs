using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Minimarket_Managment
{

    public partial class RegisterForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        //string insertQuery = "INSERT INTO Seller VALUES(" + TextBox_id.Text + ",'" + TextBox_name.Text + "','" + TextBox_age.Text + "','" + TextBox_phone.Text + "','" + TextBox_pass.Text + "')";
        //SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
        //dBCon.OpenCon();
                //command.ExecuteNonQuery();
                //MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // /dBCon.CloseCon();
                //getTable();
        //clear();
        private void button_SignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Akun VALUES('" + textBox_NameAdm.Text + "','" + textBox_UsrAdm.Text + "','" + textBox_NoAdm.Text + "','" + textBox_PassAdm.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Registration has been successful", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                clear();
                
           
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void clear()
        {
            textBox_NameAdm.Clear();
            textBox_NoAdm.Clear();
            textBox_PassAdm.Clear();
            textBox_UsrAdm.Clear();
           
        }
    }
}
