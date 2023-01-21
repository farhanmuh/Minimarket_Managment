using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Minimarket_Managment
{

    
    public partial class Form1 : Form

    {
        DBConnect dBCon = new DBConnect();
        public static string NameEmploye;

        public string NameAdm { get; private set; }
        public string UsernameAdm { get; private set; }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Usr.Text == "" || textBox_Pass.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_Role.SelectedIndex > -1)
                {
                    if (comboBox_Role.SelectedItem.ToString() == "Admin")
                    {
                        string selectQuery = "SELECT * FROM Akun WHERE UsernameAdm='" + textBox_Usr.Text + "' AND Password='" + textBox_Pass.Text + "'";

                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            UsernameAdm = textBox_Usr.Text;
                            ChooseCondition condition = new ChooseCondition();
                            condition.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are Admin, Please Enter the corret Id and Password", "Miss Id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        string selectQuery = "SELECT * FROM Employe WHERE NameEmploye='" + textBox_Usr.Text + "' AND IdEmploye='" + textBox_Pass.Text + "'";

                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dBCon.GetCon());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            NameEmploye = textBox_Usr.Text;
                            SellingForm selling = new SellingForm();
                            selling.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
