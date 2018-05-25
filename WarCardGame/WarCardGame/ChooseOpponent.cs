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
    public partial class ChooseOpponent : Form
    {
        public ChooseOpponent()
        {
            InitializeComponent();
        }

        public string PlayerName;

        private void ChooseOpponent_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxChar1_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.BackgroundImage = imageListOpponent.Images[0];
        }

        private void pictureBoxChar2_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.BackgroundImage = imageListOpponent.Images[1];
        }

        private void pictureBoxChar3_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.BackgroundImage = imageListOpponent.Images[2];
        }

        private void pictureBoxChar4_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.BackgroundImage = imageListOpponent.Images[3];
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            f1.PlayerName = PlayerName;

            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int Cardpick = rand.Next(0, 3);
        }
    }
}
