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
    public partial class SampleLogins : Form
    {
        public SampleLogins()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Employee login_Emp = new Login_Employee();
            login_Emp.Show();
            this.Hide();
        }
    }
}
