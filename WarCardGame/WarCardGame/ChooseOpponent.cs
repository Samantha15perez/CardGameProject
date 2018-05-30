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

        public int OpponentSelect;
        public string PlayerName;

        private void ChooseOpponent_Load(object sender, EventArgs e)
        {
            pictureBoxPreview.BackgroundImage = imageListOpponent.Images[0];
            label2.Text = "Placeholder.Red_Easy";
            OpponentSelect = 0;
        }

        private void pictureBoxChar1_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.BackgroundImage = imageListOpponent.Images[0];
            label2.Text = "Placeholder.Red_Easy";
            OpponentSelect = 0;
        }

        private void pictureBoxChar2_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.BackgroundImage = imageListOpponent.Images[1];
            label2.Text = "Placeholder.Blue_Medium";
            OpponentSelect = 1;
        }

        private void pictureBoxChar3_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.BackgroundImage = imageListOpponent.Images[2];
            label2.Text = "Placeholder.Yellow_Hard";
            OpponentSelect = 2;
        }

        private void pictureBoxChar4_Click(object sender, EventArgs e)
        {
            pictureBoxPreview.BackgroundImage = imageListOpponent.Images[3];
            label2.Text = "Placeholder.Green_Surprise";
            OpponentSelect = 3;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            try
            {
                
            Form1 f1 = new Form1();

            f1.PlayerName = PlayerName;
            f1.Opponent = OpponentSelect;

            this.Hide();
            f1.ShowDialog();
            this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            OpponentSelect = rand.Next(0, 4);
            pictureBoxPreview.BackgroundImage = imageListOpponent.Images[OpponentSelect];

            if (OpponentSelect == 0) { label2.Text = "Placeholder.Red_Easy"; }
            if (OpponentSelect == 1) { label2.Text = "Placeholder.Blue_Medium"; }
            if (OpponentSelect == 2) { label2.Text = "Placeholder.Yellow_Hard"; }
            if (OpponentSelect == 3) { label2.Text = "Placeholder.Green_Surprise"; }

        }

    }
}
