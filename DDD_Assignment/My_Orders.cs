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
    public partial class My_Orders : Form
    {
        public My_Orders()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(001, "2024/03/20", "Not Delivered", 25000);
            dataGridView1.Rows.Add(002, "2024/03/20", "Not Delivered", 31000);
            dataGridView1.Rows.Add(003, "2024/03/20", "Not Delivered", 18000);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
