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
    public partial class PlayerSelect : Form
    {
        public string[] PlayerNames = new string[20];
        public int[] Highscores = new int[20];
        public string[] DatePlayed = new string[20];


        public PlayerSelect()
        {
            InitializeComponent();
        }

        

        private void PlayerSelect_Load(object sender, EventArgs e)
        {
            try
            {


            StreamReader inputFile; //to read the file
            string line; //to hold a line from the file
            int count = 0; //line counter
            

            //create a delimiter array
            char[] delim = { ',' };

            //open the csv file

            inputFile = File.OpenText("Scores.CSV");

            while (!inputFile.EndOfStream)
            {
                //read a line from the file.
                line = inputFile.ReadLine();

                //get the test scores as tokens
                string[] tokens = line.Split(delim);

               
                PlayerNames[count] = tokens[0];
                Highscores[count] = int.Parse(tokens[1]);
                DatePlayed[count] = tokens[2];


                //increment the line counter
                count++;
            }

                inputFile.Close();

            listBoxPlayers.DataSource = PlayerNames;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = Highscores[listBoxPlayers.SelectedIndex].ToString();
            label5.Text = DatePlayed[listBoxPlayers.SelectedIndex];
            
            


        }

        private void buttonCreateNewPlayer_Click(object sender, EventArgs e)
        {
            NewPlayerPrompt NPP = new NewPlayerPrompt();
            this.Hide();
            NPP.ShowDialog();
            this.Close();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            try
            {

            
            ChooseOpponent CO = new ChooseOpponent();
            
            CO.PlayerName = PlayerNames[listBoxPlayers.SelectedIndex].ToString();

            this.Hide();
            CO.ShowDialog();
            this.Close();

              
            }catch
            {
                MessageBox.Show("Please Select a Player.");

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
