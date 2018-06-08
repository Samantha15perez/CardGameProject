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
 * assign a value to every card --DONE
 * create "turns"
 * create a method to have your 'opponent' pick a card --DONE
 *      (the opponent you choose will determine which cards you will fight against)
 * check both card values against each other and choose a winner
 *  for every card won, a picturebox containing a face-down card is stacked
 *  for the illusion of a growing "winnings" pile
 *  -EDIT- actually put the won cards into the player's deck
 *  
 * card value depends on the actual image name within the image list//OR the picturebox itself
 * (NOT HARDCODED) --DONE
 * 
 * 
 * 
 * save results to file
 * endgame triggers save score; the score is the number of points won in the match, with a multiplier
 * easy = x1, medium = x2, hard = x3, surprise = random
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
        public string OpponentCardValue;
        public int OpponentDeckLength = 26;
        public int PlayerDeckLength = 0;



        public Form1()
        {
            InitializeComponent();
            pictureBoxBG.Controls.Add(pictureBoxOpponent);
            pictureBoxOpponent.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            //makes the window unable to be resized
            
            label1.Text = PlayerName;
            //shows the playername! 

            if (Opponent == 0) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\WarCardGame\WarCardGame\Resources\fullbody11.png"; }
            if (Opponent == 1) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\WarCardGame\WarCardGame\Resources\Fullbody2.png"; }
            if (Opponent == 2) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\WarCardGame\WarCardGame\Resources\Fullbody3.png"; }
            if (Opponent == 3) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\WarCardGame\WarCardGame\Resources\Fullbody4.png"; }
            //loads in the opponent you chose before. 

            pictureBoxOpponent.BackgroundImageLayout = ImageLayout.None;
            //sets the image alignment so it doesnt look stretched and gross

            try
            {
                pictureBox1.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox2.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox3.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox4.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox5.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox6.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox7.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox8.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox9.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox10.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox11.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox12.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox13.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox14.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox15.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox16.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox17.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox18.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox19.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox20.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox21.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox22.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox23.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox24.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox25.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                pictureBox53.Image = imageListCardsOpponent.Images[OpponentDeckLength];
                //shows your opponent's deck facedown

                pictureBoxOpponentPreview.BackgroundImage = imageListCardsOpponent.Images[OpponentDeckLength];
                //hides your opponent's choice until you select your card (no cheating!)

                pictureBox2_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox2_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox3_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox3_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox4_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox4_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox5_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox5_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox6_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox6_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox7_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox7_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox8_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox8_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox9_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox9_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox10_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBox10_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBoxAce_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBoxAce_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBoxJack_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBoxJack_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBoxKing_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBoxKing_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBoxQueen_Diamonds.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                PlayerDeckLength++;
                pictureBoxQueen_Hearts.Image = imageListCardsPlayer.Images[PlayerDeckLength];
                
                //sets up your deck in front of you


                //pictureBoxOpponentPreview.BackgroundImage = imageListCardsOpponent.Images[CardDeckLength];

                pictureBoxPlayerPreview.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBoxOpponentPreview.BackgroundImageLayout = ImageLayout.Stretch;
                //makes it look all pretty and un-jpg-d



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //error handling; because what are we, savages?
            }
            }



        private void forfeitMatchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuitPrompt q1 = new QuitPrompt();
            q1.ShowDialog();
            //this pauses the game and pulls up the "are you sure you want to quit?" dialog
            
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions will be included soon");
            //placeholder for instructions. full instructions will be placed here.
        }

        

        private void SelectCardTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, OpponentDeckLength);
            //selects a card for your opponent to play
            
            if (imageListCardsOpponent.Images[Cardpick] == imageListCardsOpponent.Images[OpponentDeckLength])
            {
              Cardpick = rand.Next(0, OpponentDeckLength);
                //chooses a new card if it lands on the facedown; which is the last card in the image list. 
            }
            else if (!(imageListCardsOpponent.Images[Cardpick] == imageListCardsOpponent.Images[OpponentDeckLength]))
            {
              pictureBoxOpponentPreview.BackgroundImage = imageListCardsOpponent.Images[Cardpick];
                //shows the true card
            }
            if (OpponentDeckLength == 1)
            {
                MessageBox.Show("WIN");
                //if the only image within the imagelist is the facedown card, that means there are no cards left in 
                //your opponent's deck, and you win!
            }



            pictureBoxOpponentPreview.BackgroundImageLayout = ImageLayout.Stretch;

            label6.Text = PlayerCardValue.ToString();
            //test label. will be deleted later.

           
            OpponentCardValue = imageListCardsOpponent.Images.Keys[Cardpick].Substring(0, 1);
            if (imageListCardsOpponent.Images.Keys[Cardpick].Substring(0, 2) == "10") { OpponentCardValue = "10"; }
            if (OpponentCardValue == "A") { OpponentCardValue = "14"; }
            if (OpponentCardValue == "J") { OpponentCardValue = "11"; }
            if (OpponentCardValue == "K") { OpponentCardValue = "12"; }
            if (OpponentCardValue == "Q") { OpponentCardValue = "13"; }
            //this snippet of code takes the keys of the card images and uses the substring method
            //to calculate a value for the card instead of hardcoding it. 
            //(for example- 2 of clubs -> 2_Clubs.bmp -> [2]_Clubs.bmp -> value = 2)


            label5.Text = OpponentCardValue.ToString();
            //test label, will be deleted later.

            if (int.Parse(OpponentCardValue) > PlayerCardValue)
            {
                label2.Text = "-" + (int.Parse(OpponentCardValue) - PlayerCardValue).ToString();
                imageListCardsPlayer.Images.RemoveByKey(imageListCardsPlayer.Images.Keys[Cardpick]);
                PlayerDeckLength--;
                //pictureBox2_Diamonds.Refresh();
                //pictureBox3_Diamonds.Refresh();
                //pictureBox4_Diamonds.Refresh();
                //pictureBox5_Diamonds.Refresh();
                //pictureBox6_Diamonds.Refresh();
                //pictureBox7_Diamonds.Refresh();
                //pictureBox8_Diamonds.Refresh();
                //pictureBox9_Diamonds.Refresh();
                //pictureBox10_Diamonds.Refresh();
                //pictureBoxAce_Diamonds.Refresh();
                //pictureBoxJack_Diamonds.Refresh();
                //pictureBoxKing_Diamonds.Refresh();
                //pictureBoxQueen_Diamonds.Refresh();
                //pictureBox2_Hearts.Refresh();
                //pictureBox3_Hearts.Refresh();
                //pictureBox4_Hearts.Refresh();
                //pictureBox5_Hearts.Refresh();
                //pictureBox6_Hearts.Refresh();
                //pictureBox7_Hearts.Refresh();
                //pictureBox8_Hearts.Refresh();
                //pictureBox9_Hearts.Refresh();
                //pictureBox10_Hearts.Refresh();
                //pictureBoxAce_Hearts.Refresh();
                //pictureBoxJack_Hearts.Refresh();
                //pictureBoxKing_Hearts.Refresh();
                //pictureBoxQueen_Hearts.Refresh();


            }
            //if the Opponent has a higher value card, they win the round and the score is calculated.
            if (int.Parse(OpponentCardValue) < PlayerCardValue)
            {
                label2.Text = (PlayerCardValue - int.Parse(OpponentCardValue)).ToString();
                imageListCardsOpponent.Images.RemoveByKey(imageListCardsOpponent.Images.Keys[Cardpick]);
                OpponentDeckLength--;
               }
            //if the Player has a higher value card, they win the round and the score is calculated.
            //the program then deletes the opponent's card from the imagelist, or 'deck', and the calculated range for the opponent is decremented by one.
            //
            if (int.Parse(OpponentCardValue) == PlayerCardValue) { label2.Text = "DRAW";
                //the 2 lines below are only for testing
                imageListCardsOpponent.Images.RemoveByKey(imageListCardsOpponent.Images.Keys[Cardpick]);
                OpponentDeckLength--;
            }

            

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

        //when you click a card, it selects it for you in the preview.
        
    }
}
