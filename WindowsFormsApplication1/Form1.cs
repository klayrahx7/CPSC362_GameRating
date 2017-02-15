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
using System.Resources;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public bool writeReviewReady = false;           //keeps track of writeReview button
        public bool enlarged = false;                   //for clicking on cover art
        public int[] amountGameRated = new int[43];
        public float[] gameRating = new float[43];
        public bool[] rateSelected = new bool[5] { false, false, false, false, false };         //keeps track of what star is selected
        public bool[] rGreaterSelected = new bool[5] { false, false, false, false, false };
        public float currentRate;

        //strings of each games description
        public string[] gamedescription = new string[43]{Properties.Resources.NintendoLand, Properties.Resources.NewSuperMarioBros,
            Properties.Resources.RabbidsLand,Properties.Resources.SingParty,Properties.Resources.GamePartyChampions,
            Properties.Resources.FamilyParty,Properties.Resources.LegoCity,Properties.Resources.NewSuperLuigi,
            Properties.Resources.GameWario,Properties.Resources.Pikmin3,Properties.Resources.PokemonRumble,
            Properties.Resources.Wonderful101,Properties.Resources.LoZTheWindWaker,Properties.Resources.DrLuigi,
            Properties.Resources.WiiFitU,Properties.Resources.DKCountryTF,Properties.Resources.MarioKart8,
            Properties.Resources.PushmoWorld,Properties.Resources.Armillo,Properties.Resources.Bayonetta2,
            Properties.Resources.SonicBoomRoL,Properties.Resources.CaptainToadTT,Properties.Resources.KirbyRC,
            Properties.Resources.MarioParty10,Properties.Resources.Splatoon,Properties.Resources.AffordableSA,
            Properties.Resources.AmiiboTap,Properties.Resources.BlockyBot,Properties.Resources.CubeLife,
            Properties.Resources.Runbow,Properties.Resources.SuperMarioMaker,Properties.Resources.YoshisWW,
            Properties.Resources.JustDanceDP2,Properties.Resources.FatalFrameMoBW,Properties.Resources.AnimalCrossingAF,
            Properties.Resources.MarioTennisUSmash,Properties.Resources.XenobladeChroniclesX,Properties.Resources.FastRacingNeo,
            Properties.Resources.LoZTwilightPrincess,Properties.Resources.StarFoxZero,Properties.Resources.SMTxFireEmblem,
            Properties.Resources.MarioSonic2016OG,Properties.Resources.LoZ2016};

        //path for cover art
        public Image[] gameImage = new Image[43] {Properties.Resources.Nintendo_Land,Properties.Resources.super_marior_bros_u,
            Properties.Resources.rabbids_landwiiuyar1,Properties.Resources.sing_party,Properties.Resources.game_party_champions,
            Properties.Resources.family_party_30_games,Properties.Resources.lego_undercover,Properties.Resources.New_Super_Luigi_U__NA_,
            Properties.Resources.GameWario1,Properties.Resources.Pikmin_3_Nintendo_America,Properties.Resources.pokemon_rumble_u,
            Properties.Resources.wonderful_101_us_wiiu_esrb_rendjpg_e969fd,Properties.Resources.The_Wind_Waker_HD_Boxart,Properties.Resources.Dr__luigi,
            Properties.Resources.WiiFitUBoxart,Properties.Resources.donkey_kong_country_tropical_freeze,Properties.Resources.Box_NA___Mario_Kart_8,
            Properties.Resources.Pushmo_Screen_Shot_2014_06_04_09_29_11,Properties.Resources.armillo_cover,Properties.Resources.bayonetta_2,
            Properties.Resources.SB_Rise_of_Lyric_NA_Box_Art,Properties.Resources.Captain_toad,Properties.Resources.kirby_and_the_rainbow_curse_cover_800,
            Properties.Resources.mario_party_10,Properties.Resources.splatoon1,Properties.Resources.affordable_space_adventures,
            Properties.Resources.amiibo_tap,Properties.Resources.blocky_bot,Properties.Resources.cube_life,
            Properties.Resources.runbow1,Properties.Resources.super_mario_maker,Properties.Resources.yoshi_s_woolly_world,
            Properties.Resources.Just_Dance_Disney_Party_2_cover,Properties.Resources.fatal_frame_maiden_of_black_water,Properties.Resources.animal_crossing_amiibo_festival,
            Properties.Resources.mario_tennis_ultra_smash,Properties.Resources.xenoblade_chronicles_x,Properties.Resources.FAST_Racing_Neo_Key_Artwork,
            Properties.Resources.The_Legend_of_Zelda_Twilight_Princess_Game_Cover,Properties.Resources.star_fox_zero,Properties.Resources.Genei_Ibun_Roku_FE_Feature_Scans_15,
            Properties.Resources._142666_L_LO,Properties.Resources.wii_u_zelda };
        
        //path for written reviews
        public string[] Reviews = new string[43] {"NintendoLandReview.txt", "NewSuperMarioBroReviews.txt",
            "RabbidsLandReviews.txt","SingPARTYReviews.txt","GamePartyChampionsReviews.txt",
            "FamilyPartyReviews.txt","LegoCityUndercoverReviews.txt","NewSuperLuigiUReviews.txt",
            "Game_WarioReviews.txt","Pikmin3Reviews.txt","PokemonRumbleUReviews.txt",
            "TheWonderful101Reviews.txt","LoZWindWalkerReviews.txt","DrLuigiReviews.txt",
            "WiiFitUReviews.txt","DKTropicalFreezeReviews.txt","MarioKart8Reviews.txt",
            "PushmoWorldReviews.txt","ArmilloReviews.txt","Bayonetta2Reviews.txt",
            "SonicBoomRoLReviews.txt","CaptainToadTTReviews.txt","KirbyRCReviews.txt",
            "MarioParty10Reviews.txt","SplatoonReviews.txt","AffordableSAReviews.txt",
            "AmiiboTapReviews.txt","BlockyBotReviews.txt","CubeLifeISReviews.txt",
            "RunbowReviews.txt","SuperMarioMakerReviews.txt","YoshiWoolyWorldReviews.txt",
            "JustDanceDP2Reviews.txt","FatalFramMoBWReviews.txt","AnimalCrossingAFReviews.txt",
            "MarioTennisUSReviews.txt","XenobladeXReviews.txt","FastRacingNeoReviews.txt",
            "LoZTwilightPrincessReviews.txt","StarFoxZeroReviews.txt","SMTXFireEmblemReviews.txt",
            "MarioSonic2016OGReviews.txt","LoZ2016Reviews.txt"};

        public string[] ReleasDate = new string[]{"November 18, 2012","November 18, 2012","November 18, 2012",
        "November 18, 2012","November 18, 2012","December 04, 2012","March 18, 2013","June 20, 2013",
        "June 23, 2013","August 4, 2013", "August 29, 2013","September 10, 2013","October 4, 2013",
        "December 31, 2013","January 10, 2014","February 21, 2014","May 30, 2014", "June 19, 2014",
        "July 3, 2014","October 24, 2014","November 11, 2014","December 04, 2014","February 20, 2015",
        "March 20, 2015","May 29, 2015","April 9, 2015","April 30, 2015","May 21, 2015","June 4, 2015",
        "August 27, 2015","September 11, 2015","Oct 16, 2015","October 20, 2015","Oct 22, 2015",
        "November 13, 2015","November 20, 2015","December 4, 2015","December 10, 2015","March 4, 2016",
        "April 22, 2016","2016","2016","2016"};

        public Form1()
        {
            InitializeComponent();
            
            //read any saved ratings from CounterAndRatings.txt
            StreamReader sr = File.OpenText("CounterAndRatings.txt");
            if (new FileInfo("CounterAndRatings.txt").Length > 0)
            {
                for (int i = 0; i < 43; i++)
                {
                    amountGameRated[i] = int.Parse(sr.ReadLine());
                    gameRating[i] = float.Parse(sr.ReadLine());
                }
            }
            else
            {
                for (int i = 0; i < 43; i++)
                {
                    amountGameRated[i] = 0;
                    gameRating[i] = 0;
                }
            }
            sr.Close();
        }

        private void WiiGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int listPosition = WiiGameList.SelectedIndex;
            if (amountGameRated[listPosition] > 0)
            {
                currentRate = gameRating[listPosition] / amountGameRated[listPosition];
                
            }
            else
                currentRate = 0;
            GameInfoText.Text = gamedescription[listPosition];
            GameCovers.BackgroundImage = gameImage[listPosition];
            string releaseText = "Release: " + ReleasDate[listPosition];
            string titleText = "Game: " + WiiGameList.GetItemText(WiiGameList.SelectedItem);
            string ratingText = WiiGameList.GetItemText(WiiGameList.SelectedItem) + "'s current Ranking: " + string.Format("{0:0.0}", currentRate);
            GameTitleLabel.Text = titleText;
            RatingLabel.Text = ratingText;
            ReleaseDateLabel.Text = releaseText;
            StarRating1.Enabled = true;
            StarRating2.Enabled = true;
            StarRating3.Enabled = true;
            StarRating4.Enabled = true;
            StarRating5.Enabled = true;
            StarRating1.FlatAppearance.BorderColor = Color.Gold;
            StarRating2.FlatAppearance.BorderColor = Color.Gold;
            StarRating3.FlatAppearance.BorderColor = Color.Gold;
            StarRating4.FlatAppearance.BorderColor = Color.Gold;
            StarRating5.FlatAppearance.BorderColor = Color.Gold;
            for (int i = 0; i < 5; i++)
            {
                rateSelected[i] = false;
                rGreaterSelected[i] = false;
            }
        }

        private void StarRating1_Click(object sender, EventArgs e)
        {
            StarRating1.FlatAppearance.BorderColor = Color.Blue;
            StarRating2.FlatAppearance.BorderColor = Color.Gold;
            StarRating3.FlatAppearance.BorderColor = Color.Gold;
            StarRating4.FlatAppearance.BorderColor = Color.Gold;
            StarRating5.FlatAppearance.BorderColor = Color.Gold;
            rateSelected[0] = true;
            for (int i=1; i < 5; i++)
            {
                rateSelected[i] = false;
            }
        }

        private void StarRating2_Click(object sender, EventArgs e)
        {
            StarRating1.FlatAppearance.BorderColor = Color.Blue;
            StarRating2.FlatAppearance.BorderColor = Color.Blue;
            StarRating3.FlatAppearance.BorderColor = Color.Gold;
            StarRating4.FlatAppearance.BorderColor = Color.Gold;
            StarRating5.FlatAppearance.BorderColor = Color.Gold;
            for (int i = 0; i < 5; i++)
            {
                if (i == 1)
                {
                    rateSelected[i] = true;
                }
                else
                    rateSelected[i] = false;
            }
            rGreaterSelected[0] = true;
            for (int i = 1; i < 5; i++)
            {
                rGreaterSelected[i] = false;
            }
        }

        private void StarRating3_Click(object sender, EventArgs e)
        {
            StarRating1.FlatAppearance.BorderColor = Color.Blue;
            StarRating2.FlatAppearance.BorderColor = Color.Blue;
            StarRating3.FlatAppearance.BorderColor = Color.Blue;
            StarRating4.FlatAppearance.BorderColor = Color.Gold;
            StarRating5.FlatAppearance.BorderColor = Color.Gold;
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    rateSelected[i] = true;
                }
                else
                    rateSelected[i] = false;
                if (i < 2)
                {
                    rGreaterSelected[i] = true;
                }
                else
                    rGreaterSelected[i] = false;
            }

        }

        private void StarRating4_Click(object sender, EventArgs e)
        {
            StarRating1.FlatAppearance.BorderColor = Color.Blue;
            StarRating2.FlatAppearance.BorderColor = Color.Blue;
            StarRating3.FlatAppearance.BorderColor = Color.Blue;
            StarRating4.FlatAppearance.BorderColor = Color.Blue;
            StarRating5.FlatAppearance.BorderColor = Color.Gold;
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    rateSelected[i] = true;
                }
                else
                    rateSelected[i] = false;
                if (i < 3)
                {
                    rGreaterSelected[i] = true;
                }
                else
                    rGreaterSelected[i] = false;
            }

        }

        private void StarRating5_Click(object sender, EventArgs e)
        {
            StarRating1.FlatAppearance.BorderColor = Color.Blue;
            StarRating2.FlatAppearance.BorderColor = Color.Blue;
            StarRating3.FlatAppearance.BorderColor = Color.Blue;
            StarRating4.FlatAppearance.BorderColor = Color.Blue;
            StarRating5.FlatAppearance.BorderColor = Color.Blue;
            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                {
                    rateSelected[i] = true;
                }
                else
                    rateSelected[i] = false;
                if (i < 4)
                {
                    rGreaterSelected[i] = true;
                }
                else
                    rGreaterSelected[i] = false;
            }

        }

        private void StarRating1_MouseEnter(object sender, EventArgs e)
        {
            if (rateSelected[0] == false)
            {
                StarRating1.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void StarRating1_MouseLeave(object sender, EventArgs e)
        {
            if (rateSelected[0] == true)
            {
                StarRating1.FlatAppearance.BorderColor = Color.Blue;
            }
            else
            {
                if (rGreaterSelected[0] == true)
                {
                    StarRating1.FlatAppearance.BorderColor = Color.Blue;
                }
                else
                {
                    StarRating1.FlatAppearance.BorderColor = Color.Gold;
                }
            }
                
        }

        private void StarRating2_MouseEnter(object sender, EventArgs e)
        {
            if (rateSelected[1] == false)
            {
                StarRating2.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void StarRating2_MouseLeave(object sender, EventArgs e)
        {
            if (rateSelected[1] == true)
            {
                StarRating2.FlatAppearance.BorderColor = Color.Blue;
            }
            else
            {
                if (rGreaterSelected[1] == true)
                {
                    StarRating2.FlatAppearance.BorderColor = Color.Blue;
                }
                else
                    StarRating2.FlatAppearance.BorderColor = Color.Gold;
            }
        }

        private void StarRating3_MouseEnter(object sender, EventArgs e)
        {
            if (rateSelected[2] == false)
            {
                StarRating3.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void StarRating3_MouseLeave(object sender, EventArgs e)
        {
            if (rateSelected[2] == true)
            {
                StarRating3.FlatAppearance.BorderColor = Color.Blue;
            }
            else
            {
                if (rGreaterSelected[2] == true)
                {
                    StarRating3.FlatAppearance.BorderColor = Color.Blue;
                }
                else
                    StarRating3.FlatAppearance.BorderColor = Color.Gold;
            }
        }

        private void StarRating4_MouseEnter(object sender, EventArgs e)
        {
            if (rateSelected[3] == false)
            {
                StarRating4.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void StarRating4_MouseLeave(object sender, EventArgs e)
        {
            if (rateSelected[3] == true)
            {
                StarRating4.FlatAppearance.BorderColor = Color.Blue;
            }
            else
            {
                if (rGreaterSelected[3] == true)
                {
                    StarRating4.FlatAppearance.BorderColor = Color.Blue;
                }
                else
                    StarRating4.FlatAppearance.BorderColor = Color.Gold;
            }
        }

        private void StarRating5_MouseEnter(object sender, EventArgs e)
        {
            if (rateSelected[4] == false)
            {
                StarRating5.FlatAppearance.BorderColor = Color.Red;
            }
        }

        private void StarRating5_MouseLeave(object sender, EventArgs e)
        {
            if (rateSelected[4] == true)
            {
                StarRating5.FlatAppearance.BorderColor = Color.Blue;
            }
            else
            {
                if (rGreaterSelected[4] == true)
                {
                    StarRating5.FlatAppearance.BorderColor = Color.Blue;
                }
                else
                    StarRating5.FlatAppearance.BorderColor = Color.Gold;
            }
        }

        private void RateItButton_Click(object sender, EventArgs e)
        {
            int listPosition = WiiGameList.SelectedIndex;
            float addRating = 0;
            bool ratingFound = false;
            for (int i = 0; i < 5; i++)
            {
                if (rateSelected[i] == true)
                {
                    ratingFound = true;
                    addRating = i + 1;
                    amountGameRated[listPosition] += 1;
                    gameRating[listPosition] += addRating;
                    
                }
                rateSelected[i] = false;
                rGreaterSelected[i] = false;
            }
            if (ratingFound == false)
            {
                string errorMessage = "No Rating Selected";
                MessageBox.Show(errorMessage);
            }
            else
            {
                currentRate = gameRating[listPosition] / amountGameRated[listPosition];
                
                string ratingText = WiiGameList.GetItemText(WiiGameList.SelectedItem) + "'s current Ranking: " + string.Format("{0:0.0}",currentRate);
                RatingLabel.Text = ratingText;
                StarRating1.FlatAppearance.BorderColor = Color.Gold;
                StarRating2.FlatAppearance.BorderColor = Color.Gold;
                StarRating3.FlatAppearance.BorderColor = Color.Gold;
                StarRating4.FlatAppearance.BorderColor = Color.Gold;
                StarRating5.FlatAppearance.BorderColor = Color.Gold;

                if (writeReviewReady == true)
                {
                    StreamWriter sw = File.AppendText(Reviews[listPosition]);
                    string rev = WriteReview.Text;
                    if (String.IsNullOrWhiteSpace(rev))
                        ReadGameDescriptionButton.PerformClick();
                    else
                    {
                        sw.WriteLine("");
                        sw.WriteLine("");
                        sw.WriteLine("Game Rated: " + string.Format("{0:0.0}", addRating));
                        sw.WriteLine(rev);
                    }
                    sw.Close();
                    WriteReview.Clear();
                    ReadGameDescriptionButton.PerformClick();
                }
            }
        }

        private void GameCovers_Click(object sender, EventArgs e)
        {
            if (enlarged == true)
            {
                GameCovers.SendToBack();
                GameCovers.Width = 275;
                GameCovers.Height = 310;
                enlarged = false;
            }
            else
            {
                GameCovers.BringToFront();
                GameCovers.Width = 315;
                GameCovers.Height = 370;
                enlarged = true;
            }
        }

        private void ReadGameDescriptionButton_Click(object sender, EventArgs e)
        {
            int listPosition = WiiGameList.SelectedIndex;
            reviewEnded();
            if(listPosition != -1)
                GameInfoText.Text = gamedescription[listPosition];
        }

        private void ReadReviewButton_Click(object sender, EventArgs e)
        {
            int listPosition = WiiGameList.SelectedIndex;
            reviewEnded();
            if (listPosition != -1)
            {
                StreamReader sr = File.OpenText(Reviews[listPosition]);
                string s = sr.ReadToEnd();
                GameInfoText.Text = s;
                sr.Close();
            }
            
        }

        private void WriteReviewButton_Click(object sender, EventArgs e)
        {
            int listPosition = WiiGameList.SelectedIndex;
            if (listPosition != -1)
            {
                writeReviewReady = true;
                WriteReview.Visible = true;
                WriteReview.Enabled = true;
                GameInfoText.Visible = false;
                GameInfoText.Enabled = false;
            }
        }
        public void reviewEnded()
        {
            writeReviewReady = false;
            WriteReview.Visible = false;
            WriteReview.Enabled = false;
            GameInfoText.Enabled = true;
            GameInfoText.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("CounterAndRatings.txt");
            for (int i = 0; i < 43; i++)
            {
                sw.WriteLine(amountGameRated[i]);
                sw.WriteLine(gameRating[i]);
            }
            sw.Close();
        }
    }
}