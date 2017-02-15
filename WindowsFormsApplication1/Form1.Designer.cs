using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace WindowsFormsApplication1
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
            this.WiiGameList = new System.Windows.Forms.ListBox();
            this.StarRating1 = new System.Windows.Forms.RadioButton();
            this.StarRating2 = new System.Windows.Forms.RadioButton();
            this.StarRating3 = new System.Windows.Forms.RadioButton();
            this.StarRating4 = new System.Windows.Forms.RadioButton();
            this.StarRating5 = new System.Windows.Forms.RadioButton();
            this.GameTitleLabel = new System.Windows.Forms.Label();
            this.RateItButton = new System.Windows.Forms.Button();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GameInfoText = new System.Windows.Forms.TextBox();
            this.GameCovers = new System.Windows.Forms.PictureBox();
            this.ReadGameDescriptionButton = new System.Windows.Forms.Button();
            this.ReadReviewButton = new System.Windows.Forms.Button();
            this.WriteReview = new System.Windows.Forms.TextBox();
            this.WriteReviewButton = new System.Windows.Forms.Button();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameCovers)).BeginInit();
            this.SuspendLayout();
            // 
            // WiiGameList
            // 
            this.WiiGameList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WiiGameList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WiiGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WiiGameList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WiiGameList.FormattingEnabled = true;
            this.WiiGameList.ItemHeight = 16;
            this.WiiGameList.Items.AddRange(new object[] {
            "Nintendo Land",
            "New Super Mario Bros. U",
            "Rabbids Land",
            "Sing PARTY",
            "Game Party Champions",
            "Family Party: 30 Great Games Obstavle Arcade",
            "Lego City Undercover",
            "New Super Luigi U",
            "Game & Wario",
            "Pikmin 3",
            "Pokemon Rumble U",
            "The Wonderful 101",
            "The Legend of Zelda: The Wind Walker HD",
            "Dr. Luigi",
            "Wii Fit U",
            "Donky Kong Country: Tropical Freeze",
            "Mario Kart 8",
            "Pushmo World",
            "Armillo",
            "Bayonetta 2",
            "Sonic Boom: Rise of Lyric",
            "Captian Toad: Treasure Tracker",
            "Kirby and the Rainbow Curse",
            "Mario Party 10",
            "Splatoon",
            "Affordable Space Adventures",
            "Amiibo Tap: Nintendo\'s Greatest Bits",
            "Blocky Bot",
            "Cube Life: Island Survival",
            "Runbow",
            "Super Mario Maker",
            "Yoshi\'s Wooly World",
            "Just Dance: Disney Party 2",
            "Fatal Frame: Maiden of Black Water",
            "Animal Crossing: Amiibo Festival",
            "Mario Tennis Ultra Smash",
            "Xenoblade Chronicles X",
            "Fast Racing Neo",
            "The Legend of Zelda: Twilight Princess HD",
            "Star Fox Zero",
            "Shin Megami Tensei X Fire Emblem",
            "Mario & Sonic at the Rio 2016 Olympic Games",
            "The Legend of Zelda (2016)"});
            this.WiiGameList.Location = new System.Drawing.Point(770, 155);
            this.WiiGameList.Name = "WiiGameList";
            this.WiiGameList.Size = new System.Drawing.Size(242, 356);
            this.WiiGameList.TabIndex = 0;
            this.WiiGameList.SelectedIndexChanged += new System.EventHandler(this.WiiGameList_SelectedIndexChanged);
            // 
            // StarRating1
            // 
            this.StarRating1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StarRating1.Appearance = System.Windows.Forms.Appearance.Button;
            this.StarRating1.BackColor = System.Drawing.Color.Transparent;
            this.StarRating1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StarRating1.Enabled = false;
            this.StarRating1.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.StarRating1.FlatAppearance.BorderSize = 2;
            this.StarRating1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.StarRating1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StarRating1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StarRating1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarRating1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarRating1.ForeColor = System.Drawing.Color.Black;
            this.StarRating1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StarRating1.Location = new System.Drawing.Point(403, 95);
            this.StarRating1.Name = "StarRating1";
            this.StarRating1.Size = new System.Drawing.Size(49, 54);
            this.StarRating1.TabIndex = 1;
            this.StarRating1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.StarRating1.UseVisualStyleBackColor = false;
            this.StarRating1.Click += new System.EventHandler(this.StarRating1_Click);
            this.StarRating1.MouseEnter += new System.EventHandler(this.StarRating1_MouseEnter);
            this.StarRating1.MouseLeave += new System.EventHandler(this.StarRating1_MouseLeave);
            // 
            // StarRating2
            // 
            this.StarRating2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StarRating2.Appearance = System.Windows.Forms.Appearance.Button;
            this.StarRating2.BackColor = System.Drawing.Color.Transparent;
            this.StarRating2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StarRating2.Enabled = false;
            this.StarRating2.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.StarRating2.FlatAppearance.BorderSize = 2;
            this.StarRating2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.StarRating2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StarRating2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StarRating2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarRating2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarRating2.ForeColor = System.Drawing.Color.Black;
            this.StarRating2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StarRating2.Location = new System.Drawing.Point(453, 95);
            this.StarRating2.Name = "StarRating2";
            this.StarRating2.Size = new System.Drawing.Size(49, 54);
            this.StarRating2.TabIndex = 2;
            this.StarRating2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.StarRating2.UseVisualStyleBackColor = false;
            this.StarRating2.Click += new System.EventHandler(this.StarRating2_Click);
            this.StarRating2.MouseEnter += new System.EventHandler(this.StarRating2_MouseEnter);
            this.StarRating2.MouseLeave += new System.EventHandler(this.StarRating2_MouseLeave);
            // 
            // StarRating3
            // 
            this.StarRating3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StarRating3.Appearance = System.Windows.Forms.Appearance.Button;
            this.StarRating3.BackColor = System.Drawing.Color.Transparent;
            this.StarRating3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StarRating3.Enabled = false;
            this.StarRating3.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.StarRating3.FlatAppearance.BorderSize = 2;
            this.StarRating3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.StarRating3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StarRating3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StarRating3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarRating3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarRating3.ForeColor = System.Drawing.Color.Black;
            this.StarRating3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StarRating3.Location = new System.Drawing.Point(503, 95);
            this.StarRating3.Name = "StarRating3";
            this.StarRating3.Size = new System.Drawing.Size(49, 54);
            this.StarRating3.TabIndex = 3;
            this.StarRating3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.StarRating3.UseVisualStyleBackColor = false;
            this.StarRating3.Click += new System.EventHandler(this.StarRating3_Click);
            this.StarRating3.MouseEnter += new System.EventHandler(this.StarRating3_MouseEnter);
            this.StarRating3.MouseLeave += new System.EventHandler(this.StarRating3_MouseLeave);
            // 
            // StarRating4
            // 
            this.StarRating4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StarRating4.Appearance = System.Windows.Forms.Appearance.Button;
            this.StarRating4.BackColor = System.Drawing.Color.Transparent;
            this.StarRating4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StarRating4.Enabled = false;
            this.StarRating4.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.StarRating4.FlatAppearance.BorderSize = 2;
            this.StarRating4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.StarRating4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StarRating4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StarRating4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarRating4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarRating4.ForeColor = System.Drawing.Color.Black;
            this.StarRating4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StarRating4.Location = new System.Drawing.Point(553, 95);
            this.StarRating4.Name = "StarRating4";
            this.StarRating4.Size = new System.Drawing.Size(49, 54);
            this.StarRating4.TabIndex = 4;
            this.StarRating4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.StarRating4.UseVisualStyleBackColor = false;
            this.StarRating4.Click += new System.EventHandler(this.StarRating4_Click);
            this.StarRating4.MouseEnter += new System.EventHandler(this.StarRating4_MouseEnter);
            this.StarRating4.MouseLeave += new System.EventHandler(this.StarRating4_MouseLeave);
            // 
            // StarRating5
            // 
            this.StarRating5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StarRating5.Appearance = System.Windows.Forms.Appearance.Button;
            this.StarRating5.BackColor = System.Drawing.Color.Transparent;
            this.StarRating5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StarRating5.Enabled = false;
            this.StarRating5.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.StarRating5.FlatAppearance.BorderSize = 2;
            this.StarRating5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.StarRating5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StarRating5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StarRating5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarRating5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarRating5.ForeColor = System.Drawing.Color.Black;
            this.StarRating5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StarRating5.Location = new System.Drawing.Point(603, 95);
            this.StarRating5.Name = "StarRating5";
            this.StarRating5.Size = new System.Drawing.Size(49, 54);
            this.StarRating5.TabIndex = 5;
            this.StarRating5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.StarRating5.UseVisualStyleBackColor = false;
            this.StarRating5.Click += new System.EventHandler(this.StarRating5_Click);
            this.StarRating5.MouseEnter += new System.EventHandler(this.StarRating5_MouseEnter);
            this.StarRating5.MouseLeave += new System.EventHandler(this.StarRating5_MouseLeave);
            // 
            // GameTitleLabel
            // 
            this.GameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameTitleLabel.AutoSize = true;
            this.GameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitleLabel.Location = new System.Drawing.Point(30, 29);
            this.GameTitleLabel.Name = "GameTitleLabel";
            this.GameTitleLabel.Size = new System.Drawing.Size(80, 25);
            this.GameTitleLabel.TabIndex = 6;
            this.GameTitleLabel.Text = "Game:";
            this.GameTitleLabel.Click += new System.EventHandler(this.WiiGameList_SelectedIndexChanged);
            // 
            // RateItButton
            // 
            this.RateItButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RateItButton.BackColor = System.Drawing.Color.Transparent;
            this.RateItButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateItButton.Location = new System.Drawing.Point(487, 155);
            this.RateItButton.Name = "RateItButton";
            this.RateItButton.Size = new System.Drawing.Size(97, 23);
            this.RateItButton.TabIndex = 7;
            this.RateItButton.Text = "Rate It";
            this.RateItButton.UseVisualStyleBackColor = false;
            this.RateItButton.Click += new System.EventHandler(this.RateItButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingLabel.Location = new System.Drawing.Point(399, 63);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(137, 20);
            this.RatingLabel.TabIndex = 8;
            this.RatingLabel.Text = "Current Rating: ";
            // 
            // GameInfoText
            // 
            this.GameInfoText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameInfoText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GameInfoText.Location = new System.Drawing.Point(351, 215);
            this.GameInfoText.Multiline = true;
            this.GameInfoText.Name = "GameInfoText";
            this.GameInfoText.ReadOnly = true;
            this.GameInfoText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GameInfoText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GameInfoText.Size = new System.Drawing.Size(367, 300);
            this.GameInfoText.TabIndex = 9;
            // 
            // GameCovers
            // 
            this.GameCovers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameCovers.Location = new System.Drawing.Point(35, 145);
            this.GameCovers.Name = "GameCovers";
            this.GameCovers.Size = new System.Drawing.Size(275, 310);
            this.GameCovers.TabIndex = 10;
            this.GameCovers.TabStop = false;
            this.GameCovers.Click += new System.EventHandler(this.GameCovers_Click);
            // 
            // ReadGameDescriptionButton
            // 
            this.ReadGameDescriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadGameDescriptionButton.Location = new System.Drawing.Point(387, 186);
            this.ReadGameDescriptionButton.Name = "ReadGameDescriptionButton";
            this.ReadGameDescriptionButton.Size = new System.Drawing.Size(103, 23);
            this.ReadGameDescriptionButton.TabIndex = 11;
            this.ReadGameDescriptionButton.Text = "GameDescription";
            this.ReadGameDescriptionButton.UseVisualStyleBackColor = true;
            this.ReadGameDescriptionButton.Click += new System.EventHandler(this.ReadGameDescriptionButton_Click);
            // 
            // ReadReviewButton
            // 
            this.ReadReviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadReviewButton.Location = new System.Drawing.Point(496, 184);
            this.ReadReviewButton.Name = "ReadReviewButton";
            this.ReadReviewButton.Size = new System.Drawing.Size(106, 23);
            this.ReadReviewButton.TabIndex = 12;
            this.ReadReviewButton.Text = "ReadReviews";
            this.ReadReviewButton.UseVisualStyleBackColor = true;
            this.ReadReviewButton.Click += new System.EventHandler(this.ReadReviewButton_Click);
            // 
            // WriteReview
            // 
            this.WriteReview.Enabled = false;
            this.WriteReview.Location = new System.Drawing.Point(351, 215);
            this.WriteReview.MaxLength = 300;
            this.WriteReview.Multiline = true;
            this.WriteReview.Name = "WriteReview";
            this.WriteReview.Size = new System.Drawing.Size(367, 300);
            this.WriteReview.TabIndex = 13;
            this.WriteReview.Visible = false;
            // 
            // WriteReviewButton
            // 
            this.WriteReviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteReviewButton.Location = new System.Drawing.Point(609, 183);
            this.WriteReviewButton.Name = "WriteReviewButton";
            this.WriteReviewButton.Size = new System.Drawing.Size(90, 23);
            this.WriteReviewButton.TabIndex = 14;
            this.WriteReviewButton.Text = "WriteReview";
            this.WriteReviewButton.UseVisualStyleBackColor = true;
            this.WriteReviewButton.Click += new System.EventHandler(this.WriteReviewButton_Click);
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseDateLabel.Location = new System.Drawing.Point(35, 84);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(64, 15);
            this.ReleaseDateLabel.TabIndex = 15;
            this.ReleaseDateLabel.Text = "Release:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 642);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.WriteReviewButton);
            this.Controls.Add(this.WriteReview);
            this.Controls.Add(this.ReadReviewButton);
            this.Controls.Add(this.ReadGameDescriptionButton);
            this.Controls.Add(this.GameCovers);
            this.Controls.Add(this.GameInfoText);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.RateItButton);
            this.Controls.Add(this.GameTitleLabel);
            this.Controls.Add(this.StarRating5);
            this.Controls.Add(this.StarRating4);
            this.Controls.Add(this.StarRating3);
            this.Controls.Add(this.StarRating2);
            this.Controls.Add(this.StarRating1);
            this.Controls.Add(this.WiiGameList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game Rater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPainting);
            ((System.ComponentModel.ISupportInitialize)(this.GameCovers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.ListBox WiiGameList;
        private System.Windows.Forms.RadioButton StarRating1;
        public void MyPainting(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            //set star locations
            PointF[] Star1 = Calculate5StarPoints(new PointF(427, 122f), 25f, 10f);
            SolidBrush FillBrush = new SolidBrush(Color.Gold);
            G.FillPolygon(FillBrush, Star1);
            PointF[] Star2 = Calculate5StarPoints(new PointF(477f, 122f), 25f, 10f);
            G.FillPolygon(FillBrush, Star2);
            PointF[] Star3 = Calculate5StarPoints(new PointF(527f, 122f), 25f, 10f);
            G.FillPolygon(FillBrush, Star3);
            PointF[] Star4 = Calculate5StarPoints(new PointF(577f, 122f), 25f, 10f);
            G.FillPolygon(FillBrush, Star4);
            PointF[] Star5 = Calculate5StarPoints(new PointF(627f, 122f), 25f, 10f);
            G.FillPolygon(FillBrush, Star5);

        }
        /// <summary>
        /// Return an array of 10 points to be used in a Draw- or FillPolygon method
        /// </summary>
        /// <param name="Orig"> The origin is the middle of the star.</param>
        /// <param name="outerradius">Radius of the surrounding circle.</param>
        /// <param name="innerradius">Radius of the circle for the "inner" points</param>
        /// <returns>Array of 10 PointF structures</returns>
        /// "Draw Any Star You Want." DaniWeb. Ddanbe, n.d. Web. 11 Feb. 2016. <https://www.daniweb.com/programming/software-development/code/360165/draw-any-star-you-want->.
        private PointF[] Calculate5StarPoints(PointF Orig, float outerradius, float innerradius)
        {
            // Define some variables to avoid as much calculations as possible
            // conversions to radians
            double Ang36 = Math.PI / 5.0;   // 36° x PI/180
            double Ang72 = 2.0 * Ang36;     // 72° x PI/180
            // some sine and cosine values we need
            float Sin36 = (float)Math.Sin(Ang36);
            float Sin72 = (float)Math.Sin(Ang72);
            float Cos36 = (float)Math.Cos(Ang36);
            float Cos72 = (float)Math.Cos(Ang72);
            // Fill array with 10 origin points
            PointF[] pnts = { Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig };
            pnts[0].Y -= outerradius;  // top off the star, or on a clock this is 12:00 or 0:00 hours
            pnts[1].X += innerradius * Sin36; pnts[1].Y -= innerradius * Cos36; // 0:06 hours
            pnts[2].X += outerradius * Sin72; pnts[2].Y -= outerradius * Cos72; // 0:12 hours
            pnts[3].X += innerradius * Sin72; pnts[3].Y += innerradius * Cos72; // 0:18
            pnts[4].X += outerradius * Sin36; pnts[4].Y += outerradius * Cos36; // 0:24 
            pnts[5].Y += innerradius;
            pnts[6].X += pnts[6].X - pnts[4].X; pnts[6].Y = pnts[4].Y;  // mirror point
            pnts[7].X += pnts[7].X - pnts[3].X; pnts[7].Y = pnts[3].Y;  // mirror point
            pnts[8].X += pnts[8].X - pnts[2].X; pnts[8].Y = pnts[2].Y;  // mirror point
            pnts[9].X += pnts[9].X - pnts[1].X; pnts[9].Y = pnts[1].Y;  // mirror point
            return pnts;
        }

        private RadioButton StarRating2;
        private RadioButton StarRating3;
        private RadioButton StarRating4;
        private RadioButton StarRating5;
        private Label GameTitleLabel;
        private Button RateItButton;
        private Label RatingLabel;
        private TextBox GameInfoText;
        private PictureBox GameCovers;
        private Button ReadGameDescriptionButton;
        private Button ReadReviewButton;
        private TextBox WriteReview;
        private Button WriteReviewButton;
        private Label ReleaseDateLabel;
    }
}

