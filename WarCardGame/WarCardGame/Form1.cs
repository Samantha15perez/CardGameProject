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
 * 
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
        public string[] PlayerDeck = new string[26];
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
            label1.Text = PlayerName;
            if (Opponent == 0) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\Fullbody1.png"; }
            if (Opponent == 1) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\Fullbody2.png"; }
            if (Opponent == 2) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\Fullbody3.png"; }
            if (Opponent == 3) { pictureBoxOpponent.ImageLocation = @"C:\Users\Cyberadmin\Desktop\CardGameProject\Fullbody4.png"; }

            pictureBoxOpponent.BackgroundImageLayout = ImageLayout.None;

            foreach (string card in imageListCardDeck.Images.Keys) 
            {
                

            }

            while (i < 26)
            {
                Random rand = new Random(DateTime.Now.Millisecond);
                int Cardpick = rand.Next(0, 52);

                if (!PlayerDeck.Contains(imageListCardDeck.Images.Keys[Cardpick]))
                {
                    PictureBox newCard = new PictureBox();
                    newCard.Size = new Size(50, 70);
                    newCard.Location = new Point(opponentleftpos, opponenttoppos);
                    newCard.Image = imageListCardDeck.Images[Cardpick];
                    this.Controls.Add(newCard);
                    newCard.BringToFront();
                    opponentleftpos = (opponentleftpos + 10);
                    PlayerDeck[i] = imageListCardDeck.Images.Keys[Cardpick];

                    i++;
                }
                
            }


            while (x < 26)
            {
                Random rand = new Random(DateTime.Now.Millisecond);
                int Cardpick = rand.Next(0, 51);

                
                    if (!PlayerDeck.Contains(imageListCardDeck.Images.Keys[Cardpick]))
                    {

                    if (!OpponentDeck.Contains(imageListCardDeck.Images.Keys[Cardpick]))
                    {
                        PictureBox newCard = new PictureBox();
                        newCard.Size = new Size(100, 140);
                        newCard.BackgroundImage = imageListCardDeck.Images[Cardpick];
                        newCard.BackgroundImageLayout = ImageLayout.Stretch;
                        
                        newCard.Location = new Point(leftpos, toppos);

                        this.Controls.Add(newCard);
                        newCard.BringToFront();
                        leftpos = (leftpos + 20);

                        x++;
                    }
                    OpponentDeck[x] = imageListCardDeck.Images.Keys[Cardpick];
                }

            }
        }

        private void forfeitMatchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QuitPrompt q1 = new QuitPrompt();

            q1.ShowDialog();

            
        }
    }
}
