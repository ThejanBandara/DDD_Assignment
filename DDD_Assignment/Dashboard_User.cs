﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace DDD_Assignment
{
    public partial class Dashboard_User : Form
    {
        public Dashboard_User()
        {
            InitializeComponent();
            PopulateCardList();
        }

        public void PopulateCardList()
        {
           
            string[] cardTitles = { "Iphone 12", "Iphone 14", "Iphone 14 pro", "Iphone 14 pro max", "Iphone 15 pro", "Iphone 15 Pro max", "Ipad air", "Ipad pro 2022 11In", "Ipad pro 2022 12.9In", "Macbook pro M3", "Macbook air 2020", "Macbook pro m2" };
            string[] cardImages = { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg", "11.jpg", "12.jpg" };
            int[] cardPrices = { 204990, 264990, 349990, 384990, 399990, 464990, 174990, 379990, 414990, 474990, 257990, 664990 };

            int panelWidth = 600 / 3; 

  
            for (int i = 0; i < cardTitles.Length; i++)
            {
              
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = LoadImage(cardImages[i]); 
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(panelWidth - 20, panelWidth - 20);
                pictureBox.Margin = new Padding(10); 

              
                Label titleLabel = new Label();
                titleLabel.Text = cardTitles[i];
                titleLabel.AutoSize = false;
                titleLabel.TextAlign = ContentAlignment.BottomLeft;
                titleLabel.Size = new Size(panelWidth - 20, 25);
                titleLabel.Location = new Point(10, panelWidth - 25);
                titleLabel.Font = new Font(titleLabel.Font.FontFamily, 8);
                titleLabel.Padding = new Padding(3);


                Label priceLabel = new Label();
                priceLabel.Text = "Rs." + cardPrices[i].ToString() + ".00";
                priceLabel.AutoSize = true;
                priceLabel.TextAlign = ContentAlignment.BottomLeft;
                priceLabel.Size = new Size(120, 20); 
                priceLabel.Location = new Point(10, panelWidth - 6); 
                priceLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; 
                priceLabel.Font = new Font(priceLabel.Font.FontFamily, 15);
                priceLabel.BackColor = Color.Transparent;

                
                Panel cardContainer = new RoundedPanel();
                cardContainer.Size = new Size(200, 230);
                cardContainer.BackColor = Color.White; 
                cardContainer.Padding = new Padding(5); 
                cardContainer.Margin = new Padding(10);

               
                cardContainer.Controls.Add(pictureBox);
                cardContainer.Controls.Add(titleLabel);
                cardContainer.Controls.Add(priceLabel);

                ItemList.Controls.Add(cardContainer);

               
                int row = i / 3;
                int column = i % 3;
                cardContainer.Location = new Point(10 + column * (panelWidth + 10), 10 + row * (panelWidth + 60));
            }
        }

        private Image LoadImage(string imageName)
        {
            try
            {
                
                string imagePath = $"{Application.StartupPath}\\{imageName}";
                return Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
                return null;
            }
        }

        public class RoundedPanel : Panel
        {
            public int BorderRadius { get; set; } = 10;

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
                    path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
                    path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                    path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                    path.CloseAllFigures();

                    this.Region = new Region(path);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            User_Profile profile = new User_Profile();
            profile.FormClosed += (s, args) => Show();
            profile.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Device_rating device_Rating = new Device_rating();  
            Hide();
            device_Rating.FormClosed += (s, args) => Show();
            device_Rating.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to log out?", "Confirm logout", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Close();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Place_Order place_Order = new Place_Order();
            Hide();
            place_Order.FormClosed += (s, args) => Show();
            place_Order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Rating add_Rating = new Add_Rating();
            Hide();
            add_Rating.FormClosed += (s, args) => Show();
            add_Rating.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            My_Orders my_Orders = new My_Orders();
            Hide();
            my_Orders.FormClosed += (s, args) => Show();
            my_Orders.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            My_Ratings my_Ratings = new My_Ratings();
            Hide();
            my_Ratings.FormClosed += (s, args) => Show();
            my_Ratings.Show();
        }
    }
}
