﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Tracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PO7LRD3\SQLEXPRESS01;Initial Catalog=DbMovieTracker;Integrated Security = True");

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                logPassword.PasswordChar = '\0';
            }
            else
            {
                logPassword.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string loginSql = "SELECT user_id FROM TableUser WHERE username= '" + logUsername.Text + "' and user_password= '" + logPassword.Text + "'";

                SqlCommand sqlCom = new SqlCommand(loginSql, con);
                SqlDataReader sqlDr = sqlCom.ExecuteReader();

                if (sqlDr.Read() == true)
                {
                    new MainForm().Show();
                    this.Hide();
                    Program.userID = sqlDr[0].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logUsername.Text = "";
                    logPassword.Text = "";
                    logUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Query sirasinda hata olustu!" + ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
