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
 * create a method to have your 'opponent' pick a card
 *      (the opponent you choose will determine which cards you will fight against)
 * check both card values against each other and choose a winner
 *  (decide whether or not the 'won' card goes into your deck or to the side as a prize)
 *  
 * card value depends on the actual image name within the image list
 * 
 * 
 * 
 * save results to file
 * 
 */





namespace WarCardGame
{
    public partial class Form1 : Form
    {

        public string PlayerName;
        public bool Q = false;
        public int Opponent;
        public string[] CardDeck = new string[52];
        public string[] OpponentDeck = new string[26];
        public string[] DeckOpponent = new string[26];
        public int opponentleftpos = 250;
        public int opponenttoppos = 275;
        public int leftpos = 100;
        public int toppos = 450;
        public int CardLocation = 0;
        public int i = 0;
        public int x = 0;


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

            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, 51);
            
            //i = 0;
            //while (i < 52)
            //{
                
            //    bool Hearts = imageListCardDeck.Images.Keys[i].Contains("Hearts");
            //    bool Diamonds = imageListCardDeck.Images.Keys[i].Contains("Diamonds");
            //    bool Clubs = imageListCardDeck.Images.Keys[i].Contains("Clubs");
            //    bool Spades = imageListCardDeck.Images.Keys[i].Contains("Spades");

            //    if (Hearts == true) { imageListCardsPlayer.Images.Keys.Add(imageListCardDeck.Images.Keys[i]); imageListCardsPlayer.Images.Add(imageListCardDeck.Images[i]); }
            //    if (Diamonds == true) { imageListCardsPlayer.Images.Keys.Add(imageListCardDeck.Images.Keys[i]); imageListCardsPlayer.Images.Add(imageListCardDeck.Images[i]); }
            //    if (Clubs == true) { imageListCardsOpponent.Images.Keys.Add(imageListCardDeck.Images.Keys[i]); imageListCardsOpponent.Images.Add(imageListCardDeck.Images[i]); }
            //    if (Spades == true) { imageListCardsOpponent.Images.Keys.Add(imageListCardDeck.Images.Keys[i]); imageListCardsOpponent.Images.Add(imageListCardDeck.Images[i]); }

            //    i++;
            //}

                
            }



        private void forfeitMatchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuitPrompt q1 = new QuitPrompt();

            q1.ShowDialog();

            
        }

        private void pictureBoxBG_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonRemoveCardTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, 26);
            MessageBox.Show(imageListCardDeck.Images.Keys[Cardpick].ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

                pictureBox27.Image = imageListCardsPlayer.Images[0]; 
                pictureBox28.Image = imageListCardsPlayer.Images[1]; 
                pictureBox29.Image = imageListCardsPlayer.Images[2]; 
                pictureBox30.Image = imageListCardsPlayer.Images[3]; 
                pictureBox31.Image = imageListCardsPlayer.Images[4]; 
                pictureBox32.Image = imageListCardsPlayer.Images[5]; 
                pictureBox33.Image = imageListCardsPlayer.Images[6]; 
                pictureBox34.Image = imageListCardsPlayer.Images[7]; 
                pictureBox35.Image = imageListCardsPlayer.Images[8]; 
                pictureBox36.Image = imageListCardsPlayer.Images[9]; 
                pictureBox37.Image = imageListCardsPlayer.Images[10]; 
                pictureBox38.Image = imageListCardsPlayer.Images[11]; 
                pictureBox39.Image = imageListCardsPlayer.Images[12]; 
                pictureBox40.Image = imageListCardsPlayer.Images[13]; 
                pictureBox41.Image = imageListCardsPlayer.Images[14]; 
                pictureBox42.Image = imageListCardsPlayer.Images[15]; 
                pictureBox43.Image = imageListCardsPlayer.Images[16]; 
                pictureBox44.Image = imageListCardsPlayer.Images[17]; 
                pictureBox45.Image = imageListCardsPlayer.Images[18]; 
                pictureBox46.Image = imageListCardsPlayer.Images[19]; 
                pictureBox47.Image = imageListCardsPlayer.Images[20]; 
                pictureBox48.Image = imageListCardsPlayer.Images[21]; 
                pictureBox49.Image = imageListCardsPlayer.Images[22]; 
                pictureBox50.Image = imageListCardsPlayer.Images[23]; 
                pictureBox51.Image = imageListCardsPlayer.Images[24]; 
                pictureBox52.Image = imageListCardsPlayer.Images[25];

                if (Opponent == 3) { 
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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
