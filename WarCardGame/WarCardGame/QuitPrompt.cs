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
    public partial class QuitPrompt : Form
    {
        public QuitPrompt()
        {
            InitializeComponent();
        }


        private void QuitPrompt_Load(object sender, EventArgs e)
        {

        }

        private void buttonquit_Click(object sender, EventArgs e)
        {

            Application.Exit();
            //closes all forms, effectively closing the entire program.
            
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes the prompt, continuing the game from where it left off
        }
    }
}
