using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;







namespace WarCardGame
{
    public partial class Form1 : Form
    {
        public bool Gamefinished = false;
        public string PlayerName;
        public bool Q = false;
        public int Opponent;

        public int PlayerCardValue;
        public string PlayerCard;
        public string OpponentCardValue;
        public string OpponentCard;
        public int OpponentDeckLength = 26;
        public int PlayerDeckLength = 26;



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

            if (Opponent == 0) { pictureBoxOpponent.Image = WarCardGame.Properties.Resources.ful }
            if (Opponent == 1) { pictureBoxOpponent.Image = imageListSelectedOpponent.Images[1]; }
            if (Opponent == 2) { pictureBoxOpponent.Image = imageListSelectedOpponent.Images[2]; }
            if (Opponent == 3) { pictureBoxOpponent.Image = imageListSelectedOpponent.Images[3]; }
        
            //loads in the opponent you chose before. 

            pictureBoxOpponent.BackgroundImageLayout = ImageLayout.None;
            //sets the image alignment so it doesnt look stretched and gross

            try
            { int oppX = 233;
                int count = 0;
                foreach(string card in imageListCardsOpponent.Images.Keys)
                {
                    if (count < 26)
                    {
                        string[] values = card.Split('_');
                        if(values[0] == "Jack")
                        {
                            values[0] = "11";
                        }
                        else if(values[0] == "Queen")
                        {
                            values[0] = "13";
                        }
                        else if(values[0] == "King")
                        {
                            values[0] = "12";
                        }
                        else if(values[0] == "Ace")
                        {
                            values[0] = "14";
                        }
                        Card newCard = new Card(int.Parse(values[0]), card);
                        Card.OpponentDeckAdd(newCard);

                        

                        PictureBox newPicBox = new PictureBox();
                        newPicBox.Size = new Size(50, 70);
                        newPicBox.Location = new Point(oppX, 286);
                        newPicBox.Tag = card;
                        newPicBox.Image = imageListCardsOpponent.Images[26];
                        this.Controls.Add(newPicBox);
                        newPicBox.BringToFront();
                        oppX += 12;
                        

                        count++;
                    }
                }


                pictureBoxOpponentPreview.BackgroundImage = imageListCardsOpponent.Images[OpponentDeckLength];
                //hides your opponent's choice until you select your card (no cheating!)

                int x = 57;
                int y = 433;
                int row = 1;

                foreach (string card in imageListCardsPlayer.Images.Keys)
                {
                    string[] values = card.Split('_');
                    if (values[0] == "Jack")
                    {
                        values[0] = "11";
                    }
                    else if (values[0] == "Queen")
                    {
                        values[0] = "13";
                    }
                    else if (values[0] == "King")
                    {
                        values[0] = "12";
                    }
                    else if (values[0] == "Ace")
                    {
                        values[0] = "14";
                    }
                    Card newCard = new Card(int.Parse(values[0]), card);
                    Card.PlayerDeckAdd(newCard);

                    PictureBox newPicBox = new PictureBox();
                    newPicBox.Size = new Size(50, 70);
                    newPicBox.Location = new Point(x, y);
                    int index = imageListCardsPlayer.Images.IndexOfKey(card);
                    newPicBox.Image = imageListCardsPlayer.Images[index];
                    newPicBox.Tag = card;
                    this.Controls.Add(newPicBox);

                    newPicBox.Click += new EventHandler(CardClick);

                    if (row == 1)
                    {
                        y += 29;
                        row++;
                    }
                    else if (row == 2)
                    {
                        x += 56;
                        y -= 29;
                        row--;
                    }
                }

                
                
                //sets up your deck in front of you




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
            MessageBox.Show("Pick a card to face off against your opponent's card. When you've made your selection, hit SELECT and whichever team picks a higher ranked card wins the round. When either team exhausts their deck, the game ends. Whoever has a higher score wins the war.");
            //Basic instructions are included in a messagebox. a more professionally packaged game would have multiple pages with screenshots, but I ran short on time. 
        }

        

        private void SelectCardTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, OpponentDeckLength);
            //pictureBoxPlayerPreview.Image = WarCardGame.Properties.Resources.Card_Select1;
            
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

                PlayerDeckLength--;

            }
            //if the Opponent has a higher value card, they win the round and the score is calculated.
            else if (int.Parse(OpponentCardValue) < PlayerCardValue)
            {
                label2.Text = (PlayerCardValue - int.Parse(OpponentCardValue)).ToString();

                OpponentDeckLength--;
            }
            //if the Player has a higher value card, they win the round and the score is calculated.
            //the program then deletes the opponent's card from the imagelist, or 'deck', and the calculated range for the opponent is decremented by one.
            //
            else if (int.Parse(OpponentCardValue) == PlayerCardValue)
            { label2.Text = "DRAW";
                //the 2 lines below are only for testing

                OpponentDeckLength--;
            }


            Card.PlayerDeckRemove(PlayerCard);
            Card.OpponentDeckRemove(OpponentCard);

            foreach(Control thing in this.Controls.OfType<PictureBox>())
            {
                if (thing.Tag.ToString() == PlayerCard)
                {
                    this.Controls.Remove(thing);
                }
            }

            


            if (!Card.GetPlayerDeck().Any() || !Card.GetOpponentDeck().Any())
            {
                if (PlayerDeckLength > OpponentDeckLength)
                {
                    MessageBox.Show("WIN");
                    this.Close();
                }
                else if (PlayerDeckLength < OpponentDeckLength)
                {
                    MessageBox.Show("LOSE");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("DRAW");
                    this.Close();
                }
            }



        }

        private void CardClick(object sender, EventArgs e)
        {
            //takes the pic the Player clicked on and turns it into a new one to mess with.
            PictureBox chosen = (PictureBox)sender;

            //go through all the Player's cards, and find the one that matches the card that was clicked.
            foreach(Card card in Card.GetPlayerDeck())
            {
                if (card.CardKey == chosen.Tag.ToString())
                {
                    PlayerCardValue = card.CardValue;
                    PlayerCard = card.CardKey;
                    
                    break;
                }
            }

            //show the card the Player clicked in the upper corner
            pictureBoxPlayerPreview.BackgroundImage = chosen.Image;

            
        }

        

    }
}
