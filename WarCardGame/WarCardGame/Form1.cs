using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* things left to do:
 * 
 * assign a value to every card
 * create "turns"
 * create a method to have your 'opponent' pick a card --DONE
 *      (the opponent you choose will determine which cards you will fight against)
 * check both card values against each other and choose a winner
 *  for every card won, a picturebox containing a face-down card is stacked
 *  for the illusion of a growing "winnings" pile
 *  
 * card value depends on the actual image name within the image list//OR the picturebox itself
 * 
 * 
 * 
 * save results to file
 * 
 * LAST- work on art;
 * opponents should have multiple sprites--
 * winning pose, losing pose, happy pose, sad pose, and standard pose. 5 total.
 * 
 */





namespace WarCardGame
{
    public partial class Form1 : Form
    {
        public bool Gamefinished = false;
        public string PlayerName;
        public bool Q = false;
        public int Opponent;
        public string[] CardDeck = new string[52];
        public int opponentleftpos = 250;
        public int opponenttoppos = 275;
        public int leftpos = 100;
        public int toppos = 450;
        public int CardLocation = 0;
        public int i = 0;
        public int x = 0;
        public int PlayerCardValue;
        public int OpponentCardValue;


        public Form1()
        {
            InitializeComponent();
            pictureBoxBG.Controls.Add(pictureBoxOpponent);
            pictureBoxOpponent.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            
            label1.Text = PlayerName;
            if (Opponent == 0) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\Fullbody11.png"; }
            if (Opponent == 1) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\Fullbody2.png"; }
            if (Opponent == 2) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\Fullbody3.png"; }
            if (Opponent == 3) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\Fullbody4.png"; }

            pictureBoxOpponent.BackgroundImageLayout = ImageLayout.None;

            try
            {
                pictureBox1.Image = imageListCardsOpponent.Images[0];
                pictureBox2.Image = imageListCardsOpponent.Images[1];
                pictureBox3.Image = imageListCardsOpponent.Images[2];
                pictureBox4.Image = imageListCardsOpponent.Images[3];
                pictureBox5.Image = imageListCardsOpponent.Images[4];
                pictureBox6.Image = imageListCardsOpponent.Images[5];
                pictureBox7.Image = imageListCardsOpponent.Images[6];
                pictureBox8.Image = imageListCardsOpponent.Images[7];
                pictureBox9.Image = imageListCardsOpponent.Images[8];
                pictureBox10.Image = imageListCardsOpponent.Images[9];
                pictureBox11.Image = imageListCardsOpponent.Images[10];
                pictureBox12.Image = imageListCardsOpponent.Images[11];
                pictureBox13.Image = imageListCardsOpponent.Images[12];
                pictureBox14.Image = imageListCardsOpponent.Images[13];
                pictureBox15.Image = imageListCardsOpponent.Images[14];
                pictureBox16.Image = imageListCardsOpponent.Images[15];
                pictureBox17.Image = imageListCardsOpponent.Images[16];
                pictureBox18.Image = imageListCardsOpponent.Images[17];
                pictureBox19.Image = imageListCardsOpponent.Images[18];
                pictureBox20.Image = imageListCardsOpponent.Images[19];
                pictureBox21.Image = imageListCardsOpponent.Images[20];
                pictureBox22.Image = imageListCardsOpponent.Images[21];
                pictureBox23.Image = imageListCardsOpponent.Images[22];
                pictureBox24.Image = imageListCardsOpponent.Images[23];
                pictureBox25.Image = imageListCardsOpponent.Images[24];
                pictureBox53.Image = imageListCardsOpponent.Images[25];

                pictureBox2_Diamonds.Image = imageListCardsPlayer.Images[0];
                pictureBox2_Hearts.Image = imageListCardsPlayer.Images[1];
                pictureBox3_Diamonds.Image = imageListCardsPlayer.Images[2];
                pictureBox3_Hearts.Image = imageListCardsPlayer.Images[3];
                pictureBox4_Diamonds.Image = imageListCardsPlayer.Images[4];
                pictureBox4_Hearts.Image = imageListCardsPlayer.Images[5];
                pictureBox5_Diamonds.Image = imageListCardsPlayer.Images[6];
                pictureBox5_Hearts.Image = imageListCardsPlayer.Images[7];
                pictureBox6_Diamonds.Image = imageListCardsPlayer.Images[8];
                pictureBox6_Hearts.Image = imageListCardsPlayer.Images[9];
                pictureBox7_Diamonds.Image = imageListCardsPlayer.Images[10];
                pictureBox7_Hearts.Image = imageListCardsPlayer.Images[11];
                pictureBox8_Diamonds.Image = imageListCardsPlayer.Images[12];
                pictureBox8_Hearts.Image = imageListCardsPlayer.Images[13];
                pictureBox9_Diamonds.Image = imageListCardsPlayer.Images[14];
                pictureBox9_Hearts.Image = imageListCardsPlayer.Images[15];
                pictureBox10_Diamonds.Image = imageListCardsPlayer.Images[16];
                pictureBox10_Hearts.Image = imageListCardsPlayer.Images[17];
                pictureBoxAce_Diamonds.Image = imageListCardsPlayer.Images[18];
                pictureBoxAce_Hearts.Image = imageListCardsPlayer.Images[19];
                pictureBoxJack_Diamonds.Image = imageListCardsPlayer.Images[20];
                pictureBoxJack_Hearts.Image = imageListCardsPlayer.Images[21];
                pictureBoxKing_Diamonds.Image = imageListCardsPlayer.Images[22];
                pictureBoxKing_Hearts.Image = imageListCardsPlayer.Images[23];
                pictureBoxQueen_Diamonds.Image = imageListCardsPlayer.Images[24];
                pictureBoxQueen_Hearts.Image = imageListCardsPlayer.Images[25];
                pictureBoxOpponentPreview.BackgroundImage = imageListCardsOpponent.Images[26];
                pictureBoxPlayerPreview.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBoxOpponentPreview.BackgroundImageLayout = ImageLayout.Stretch;

                if (Opponent == 3)
                {
                    pictureBox1.Image = imageListCardsOpponent.Images[26];
                    pictureBox2.Image = imageListCardsOpponent.Images[26];
                    pictureBox3.Image = imageListCardsOpponent.Images[26];
                    pictureBox4.Image = imageListCardsOpponent.Images[26];
                    pictureBox5.Image = imageListCardsOpponent.Images[26];
                    pictureBox6.Image = imageListCardsOpponent.Images[26];
                    pictureBox7.Image = imageListCardsOpponent.Images[26];
                    pictureBox8.Image = imageListCardsOpponent.Images[26];
                    pictureBox9.Image = imageListCardsOpponent.Images[26];
                    pictureBox10.Image = imageListCardsOpponent.Images[26];
                    pictureBox11.Image = imageListCardsOpponent.Images[26];
                    pictureBox12.Image = imageListCardsOpponent.Images[26];
                    pictureBox13.Image = imageListCardsOpponent.Images[26];
                    pictureBox14.Image = imageListCardsOpponent.Images[26];
                    pictureBox15.Image = imageListCardsOpponent.Images[26];
                    pictureBox16.Image = imageListCardsOpponent.Images[26];
                    pictureBox17.Image = imageListCardsOpponent.Images[26];
                    pictureBox18.Image = imageListCardsOpponent.Images[26];
                    pictureBox19.Image = imageListCardsOpponent.Images[26];
                    pictureBox20.Image = imageListCardsOpponent.Images[26];
                    pictureBox21.Image = imageListCardsOpponent.Images[26];
                    pictureBox22.Image = imageListCardsOpponent.Images[26];
                    pictureBox23.Image = imageListCardsOpponent.Images[26];
                    pictureBox24.Image = imageListCardsOpponent.Images[26];
                    pictureBox25.Image = imageListCardsOpponent.Images[26];
                    pictureBox53.Image = imageListCardsOpponent.Images[26];
                    pictureBoxOpponentPreview.BackgroundImage = imageListCardsOpponent.Images[26];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, 51);
            

                
            }



        private void forfeitMatchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuitPrompt q1 = new QuitPrompt();

            q1.ShowDialog();

            
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonRemoveCardTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, 26);
            MessageBox.Show(imageListCardsOpponent.Images.Keys[Cardpick].ToString());



        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions will be included soon");
        }

        

        private void SelectCardTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, 26);
            pictureBoxOpponentPreview.BackgroundImage = imageListCardsOpponent.Images[Cardpick];
            
            pictureBoxOpponentPreview.BackgroundImageLayout = ImageLayout.Stretch;
            label6.Text = PlayerCardValue.ToString();

            //THIS IS WHAT I MESSED WITH LAST
            OpponentCardValue = int.Parse(imageListCardsOpponent.Images.Keys[Cardpick].Substring(0, 1));


            label5.Text = OpponentCardValue.ToString();
            

        }

        private void pictureBox2_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBox2_Diamonds.Image; PlayerCardValue = 2; }
        private void pictureBox3_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBox3_Diamonds.Image; PlayerCardValue = 3; }
        private void pictureBox4_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBox4_Diamonds.Image; PlayerCardValue = 4; }
        private void pictureBox5_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBox5_Hearts.Image; PlayerCardValue = 5; }
        private void pictureBox6_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBox6_Diamonds.Image; PlayerCardValue = 6; }
        private void pictureBox7_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBox7_Diamonds.Image; PlayerCardValue = 7; }
        private void pictureBox8_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBox8_Diamonds.Image; PlayerCardValue = 8; }
        private void pictureBox9_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBox9_Diamonds.Image; PlayerCardValue = 9; }
        private void pictureBox10_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBox10_Diamonds.Image; PlayerCardValue = 10; }
        private void pictureBoxAce_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBoxAce_Diamonds.Image; PlayerCardValue = 14; }
        private void pictureBoxJack_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBoxJack_Diamonds.Image; PlayerCardValue = 11; }
        private void pictureBoxKing_Diamonds_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBoxKing_Diamonds.Image; PlayerCardValue = 12; }
        private void pictureBox51_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBoxQueen_Diamonds.Image; PlayerCardValue = 13; }
        private void pictureBox2_Hearts_Click(object sender, EventArgs e){ pictureBoxPlayerPreview.BackgroundImage = pictureBox2_Hearts.Image; PlayerCardValue = 2; }
        private void pictureBox3_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBox3_Hearts.Image; PlayerCardValue = 3; }
        private void pictureBox4_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBox4_Hearts.Image; PlayerCardValue = 4; }
        private void pictureBox5_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBox5_Diamonds.Image; PlayerCardValue = 5; }
        private void pictureBox6_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBox6_Hearts.Image; PlayerCardValue = 6; }
        private void pictureBox7_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBox7_Hearts.Image; PlayerCardValue = 7; }
        private void pictureBox8_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBox8_Hearts.Image; PlayerCardValue = 8; }
        private void pictureBox9_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBox9_Hearts.Image; PlayerCardValue = 9; }
        private void pictureBox10_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBox10_Hearts.Image; PlayerCardValue = 10; }
        private void pictureBoxAce_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBoxAce_Hearts.Image; PlayerCardValue = 14; }
        private void pictureBoxJack_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBoxJack_Hearts.Image; PlayerCardValue = 11; }
        private void pictureBoxKing_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBoxKing_Hearts.Image; PlayerCardValue = 12; }
        private void pictureBoxQueen_Hearts_Click(object sender, EventArgs e) { pictureBoxPlayerPreview.BackgroundImage = pictureBoxQueen_Hearts.Image; PlayerCardValue = 13; }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
