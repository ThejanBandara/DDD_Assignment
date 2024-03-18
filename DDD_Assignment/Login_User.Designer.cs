namespace DDD_Assignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            label8 = new Label();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            button1 = new Button();
            linkLabel3 = new LinkLabel();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 40);
            label1.Name = "label1";
            label1.Size = new Size(136, 62);
            label1.TabIndex = 1;
            label1.Text = "Log in";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 115);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 9;
            label2.Text = "Mobile Number";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(8, 9, 56);
            textBox1.Location = new Point(41, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 171);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 196);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 10;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(66, 135, 245);
            linkLabel1.Location = new Point(207, 337);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(54, 19);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(73, 337);
            label8.Name = "label8";
            label8.Size = new Size(139, 19);
            label8.TabIndex = 16;
            label8.Text = "Don't have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.White;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.FromArgb(66, 135, 245);
            linkLabel2.Location = new Point(134, 356);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(132, 19);
            linkLabel2.TabIndex = 19;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Log in as an employee";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(69, 356);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 18;
            label4.Text = "Work here?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(8, 9, 56);
            button1.Location = new Point(83, 248);
            button1.Name = "button1";
            button1.Size = new Size(159, 36);
            button1.TabIndex = 20;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.White;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel3.LinkColor = Color.FromArgb(66, 135, 245);
            linkLabel3.Location = new Point(109, 319);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(106, 19);
            linkLabel3.TabIndex = 21;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Forgot password?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 391);
            panel1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(8, 9, 56);
            label6.Location = new Point(12, 274);
            label6.Name = "label6";
            label6.Size = new Size(292, 51);
            label6.TabIndex = 24;
            label6.Text = "Communications";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(8, 9, 56);
            label5.Location = new Point(86, 234);
            label5.Name = "label5";
            label5.Size = new Size(123, 62);
            label5.TabIndex = 23;
            label5.Text = "Peter";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Peter_communications_logo;
            pictureBox1.Location = new Point(40, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(8, 9, 56);
            panel2.Controls.Add(linkLabel3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(308, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 386);
            panel2.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 385);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private Label label8;
        private LinkLabel linkLabel2;
        private Label label4;
        private Button button1;
        private LinkLabel linkLabel3;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}