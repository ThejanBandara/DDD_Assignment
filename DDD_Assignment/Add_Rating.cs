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
    public partial class Add_Rating : Form
    {
        public Add_Rating()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Regular;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Regular;
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Regular;
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Regular;
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Solid;
        }
    }
}
