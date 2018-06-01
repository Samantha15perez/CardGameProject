using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WarCardGame
{
    public partial class NewPlayerPrompt : Form
    {
        public NewPlayerPrompt()
        {
            InitializeComponent();
        }

        private void buttonNewPlayer_Click(object sender, EventArgs e)
        {
            string Date = DateTime.Now.ToString("MM/dd/yyyy");
            string NewPlayerName = textBoxNewPlayer.Text;
            if (NewPlayerName == "")
            {
                NewPlayerName = "Guest";
            }

            File.AppendAllText("Scores.CSV",
                   NewPlayerName + "," + "0" + "," + Date + Environment.NewLine);

            PlayerSelect PS = new PlayerSelect();
            this.Hide();
            PS.ShowDialog();
            this.Close();
        }

        private void NewPlayerPrompt_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void buttonPrevForm_Click(object sender, EventArgs e)
        {
            PlayerSelect PS = new PlayerSelect();
            this.Hide();
            PS.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
