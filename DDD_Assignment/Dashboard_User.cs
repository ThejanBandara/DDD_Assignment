using System;
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

        private void PopulateCardList()
        {
            // Example data for cards
            string[] cardTitles = { "Iphone 12", "Iphone 14", "Iphone 14 pro", "Iphone 14 pro max", "Iphone 15 pro", "Iphone 15 Pro max", "Ipad air", "Ipad pro 2022 11In", "Ipad pro 2022 12.9In", "Macbook pro M3", "Macbook air 2020", "Macbook pro m2" };
            string[] cardImages = { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg", "11.jpg", "12.jpg" };
            int[] cardPrices = { 204990, 264990, 349990, 384990, 399990, 464990, 174990, 379990, 414990, 474990, 257990, 664990 };

            int panelWidth = 600 / 3; // Divide the width of the panel by 3

            // Add cards dynamically
            for (int i = 0; i < cardTitles.Length; i++)
            {
                // Create PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = LoadImage(cardImages[i]); // Load image
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(panelWidth - 20, panelWidth - 20); // Adjust size based on panel width
                pictureBox.Margin = new Padding(10); // Add margin between cards

                // Create Label for product title
                Label titleLabel = new Label();
                titleLabel.Text = cardTitles[i];
                titleLabel.AutoSize = false;
                titleLabel.TextAlign = ContentAlignment.BottomLeft;
                titleLabel.Size = new Size(panelWidth - 20, 25); // Adjust label size based on panel width
                titleLabel.Location = new Point(10, panelWidth - 25);
                titleLabel.Font = new Font(titleLabel.Font.FontFamily, 8);
                titleLabel.Padding = new Padding(3);

                // Create Label for product price
                Label priceLabel = new Label();
                priceLabel.Text = "Rs." + cardPrices[i].ToString() + ".00";
                priceLabel.AutoSize = true;
                priceLabel.TextAlign = ContentAlignment.BottomLeft;
                priceLabel.Size = new Size(120, 20); // Adjust label size based on panel width
                priceLabel.Location = new Point(10, panelWidth - 6); // Adjust label position
                priceLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; // Anchor to bottom-left corner
                priceLabel.Font = new Font(priceLabel.Font.FontFamily, 15);
                priceLabel.BackColor = Color.Transparent;

                // Create container for each card (PictureBox and Labels)
                Panel cardContainer = new RoundedPanel();
                cardContainer.Size = new Size(200, 230); // Adjust size as needed
                cardContainer.BackColor = Color.White; // Add background color or any other styles
                cardContainer.Padding = new Padding(5); // Add padding within container
                cardContainer.Margin = new Padding(10);

                // Add PictureBox and Labels to the card container
                cardContainer.Controls.Add(pictureBox);
                cardContainer.Controls.Add(titleLabel);
                cardContainer.Controls.Add(priceLabel);

                // Add card container to the Panel
                ItemList.Controls.Add(cardContainer);

                // Position cards in rows of three
                int row = i / 3;
                int column = i % 3;
                cardContainer.Location = new Point(10 + column * (panelWidth + 10), 10 + row * (panelWidth + 60));
            }
        }

        private Image LoadImage(string imageName)
        {
            try
            {
                // Load image from root directory
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

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
