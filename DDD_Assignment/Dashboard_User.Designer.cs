namespace DDD_Assignment
{
    partial class Dashboard_User
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
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            ItemList = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 16);
            label1.Name = "label1";
            label1.Size = new Size(272, 29);
            label1.TabIndex = 2;
            label1.Text = "Peter Communications";
            // 
            // button2
            // 
            button2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 216);
            button2.Name = "button2";
            button2.Size = new Size(164, 33);
            button2.TabIndex = 1;
            button2.Text = "Rate a device";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 177);
            button1.Name = "button1";
            button1.Size = new Size(164, 33);
            button1.TabIndex = 0;
            button1.Text = "Place order";
            button1.UseVisualStyleBackColor = true;
            // 
            // ItemList
            // 
            ItemList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemList.AutoScroll = true;
            ItemList.AutoSize = true;
            ItemList.Location = new Point(168, 54);
            ItemList.MaximumSize = new Size(660, 418);
            ItemList.MinimumSize = new Size(600, 418);
            ItemList.Name = "ItemList";
            ItemList.Size = new Size(660, 418);
            ItemList.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-2, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 437);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 104);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Sample User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(0, 255);
            button3.Name = "button3";
            button3.Size = new Size(164, 33);
            button3.TabIndex = 3;
            button3.Text = "My orders";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(0, 294);
            button4.Name = "button4";
            button4.Size = new Size(164, 33);
            button4.TabIndex = 4;
            button4.Text = "My Ratings";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(0, 138);
            button5.Name = "button5";
            button5.Size = new Size(164, 33);
            button5.TabIndex = 5;
            button5.Text = "Profile";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(669, 16);
            button6.Name = "button6";
            button6.Size = new Size(164, 33);
            button6.TabIndex = 6;
            button6.Text = "Product ratings";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Dashboard_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 484);
            Controls.Add(panel2);
            Controls.Add(ItemList);
            Controls.Add(panel1);
            Name = "Dashboard_User";
            Text = "Dashboard_User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel ItemList;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;

        private Label label2;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button6;
    }
}