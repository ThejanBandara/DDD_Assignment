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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(78, 21);
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
            label2.Location = new Point(30, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 9;
            label2.Text = "Mobile Number";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 114);
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
            label3.Location = new Point(30, 158);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 10;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(189, 280);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 280);
            label8.Name = "label8";
            label8.Size = new Size(131, 15);
            label8.TabIndex = 16;
            label8.Text = "Don't have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(122, 302);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(125, 15);
            linkLabel2.TabIndex = 19;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Log in as an employee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 302);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 18;
            label4.Text = "Work here?";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(72, 228);
            button1.Name = "button1";
            button1.Size = new Size(159, 36);
            button1.TabIndex = 20;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 328);
            Controls.Add(button1);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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
    }
}