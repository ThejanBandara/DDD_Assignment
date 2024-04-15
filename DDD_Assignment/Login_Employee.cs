using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD_Assignment
{
    public partial class Login_Employee : Form
    {
        public Login_Employee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string pwd = textBox2.Text;

            if (email == null || pwd == null)
            {
                MessageBox.Show("Please Enter an Email and a password", "empty Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (email == "emp@petercomms.com" && pwd == "1234")
                {
                    Dashboard_Emp employee = new Dashboard_Emp();
                    employee.Show();
                    this.Hide();
                }
                else if (email == "man@petercomms.com" && pwd == "1234")
                {
                    Dashbaord_Man manager = new Dashbaord_Man();
                    manager.Show();
                    this.Hide();
                }
                else if (email == "dir@petercomms.com" && pwd == "1234")
                {
                    Dashboard_Dir director = new Dashboard_Dir();
                    director.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid Credentials! Please try Again", "Invalid Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
