namespace DDD_Assignment
{
    partial class Login_Employee
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
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(66, 221);
            button1.Name = "button1";
            button1.Size = new Size(159, 36);
            button1.TabIndex = 28;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(175, 290);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(50, 15);
            linkLabel2.TabIndex = 27;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go back";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 290);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 26;
            label4.Text = "Don't Work here?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 146);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 25;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 77);
            label2.Name = "label2";
            label2.Size = new Size(42, 22);
            label2.TabIndex = 23;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 62);
            label1.TabIndex = 21;
            label1.Text = "Log in";
            // 
            // Login_Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 327);
            Controls.Add(button1);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Login_Employee";
            Text = "Login_Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private LinkLabel linkLabel2;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}