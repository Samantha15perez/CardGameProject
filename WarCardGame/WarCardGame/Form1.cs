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
        public Form1()
        {
            InitializeComponent();
        }

        public string PlayerName;
        public string[] CardDeck = new string[52];
        public string[] OpponentDeck = new string[26];
        public string[] PlayerDeck = new string[26];
        public int opponentleftpos = 175;
        public int opponenttoppos = 275;
        public int leftpos = 50;
        public int toppos = 450;
        public int CardLocation = 0;
        public int i = 0;
        public int x = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = PlayerName;

            foreach (string card in imageListCardDeck.Images.Keys) 
            {
                
               // PictureBox newCard = new PictureBox();
               // newCard.Size = new Size(50, 70);

               // newCard.Location = new Point(opponentleftpos, opponenttoppos);
               // newCard.Image = imageListCardDeck.Images[CardLocation];
               // this.Controls.Add(newCard);
               // newCard.BringToFront();
               // opponentleftpos = (opponentleftpos + 10);

               // //if (opponentleftpos > 675)
               //// {
               // //    opponenttoppos = opponenttoppos + 75;
               // //    opponentleftpos = 430;
               // //}
               // CardLocation++;
            }

            while (i < 26)
            {
                Random rand = new Random(DateTime.Now.Millisecond);
                int Cardpick = rand.Next(0, 51);

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
    }
}
