namespace WarCardGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageListCardDeck = new System.Windows.Forms.ImageList(this.components);
            this.imageListCardsOpponent = new System.Windows.Forms.ImageList(this.components);
            this.imageListCardsPlayer = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            this.pictureBoxOpponent = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.forfeitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forfeitMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxOpponentPreview = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayerPreview = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectCardTest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxPickACard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponentPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPickACard)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListCardDeck
            // 
            this.imageListCardDeck.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCardDeck.ImageStream")));
            this.imageListCardDeck.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCardDeck.Images.SetKeyName(0, "2_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(1, "2_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(2, "2_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(3, "2_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(4, "3_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(5, "3_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(6, "3_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(7, "3_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(8, "4_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(9, "4_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(10, "4_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(11, "4_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(12, "5_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(13, "5_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(14, "5_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(15, "5_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(16, "6_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(17, "6_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(18, "6_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(19, "6_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(20, "7_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(21, "7_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(22, "7_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(23, "7_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(24, "8_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(25, "8_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(26, "8_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(27, "8_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(28, "9_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(29, "9_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(30, "9_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(31, "9_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(32, "10_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(33, "10_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(34, "10_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(35, "10_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(36, "Ace_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(37, "Ace_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(38, "Ace_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(39, "Ace_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(40, "Jack_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(41, "Jack_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(42, "Jack_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(43, "Jack_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(44, "King_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(45, "King_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(46, "King_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(47, "King_Spades.bmp");
            this.imageListCardDeck.Images.SetKeyName(48, "Queen_Clubs.bmp");
            this.imageListCardDeck.Images.SetKeyName(49, "Queen_Diamonds.bmp");
            this.imageListCardDeck.Images.SetKeyName(50, "Queen_Hearts.bmp");
            this.imageListCardDeck.Images.SetKeyName(51, "Queen_Spades.bmp");
            // 
            // imageListCardsOpponent
            // 
            this.imageListCardsOpponent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCardsOpponent.ImageStream")));
            this.imageListCardsOpponent.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCardsOpponent.Images.SetKeyName(0, "2_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(1, "2_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(2, "3_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(3, "3_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(4, "4_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(5, "4_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(6, "5_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(7, "5_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(8, "6_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(9, "6_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(10, "7_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(11, "7_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(12, "8_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(13, "8_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(14, "9_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(15, "9_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(16, "10_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(17, "10_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(18, "Ace_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(19, "Ace_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(20, "Jack_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(21, "Jack_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(22, "King_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(23, "King_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(24, "Queen_Clubs.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(25, "Queen_Spades.bmp");
            this.imageListCardsOpponent.Images.SetKeyName(26, "Backface_Blue.bmp");
            // 
            // imageListCardsPlayer
            // 
            this.imageListCardsPlayer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCardsPlayer.ImageStream")));
            this.imageListCardsPlayer.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCardsPlayer.Images.SetKeyName(0, "2_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(1, "2_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(2, "3_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(3, "3_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(4, "4_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(5, "4_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(6, "5_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(7, "5_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(8, "6_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(9, "6_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(10, "7_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(11, "7_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(12, "8_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(13, "8_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(14, "9_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(15, "9_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(16, "10_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(17, "10_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(18, "Ace_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(19, "Ace_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(20, "Jack_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(21, "Jack_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(22, "King_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(23, "King_Hearts.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(24, "Queen_Diamonds.bmp");
            this.imageListCardsPlayer.Images.SetKeyName(25, "Queen_Hearts.bmp");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(240, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player: ";
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxBG.Image = global::WarCardGame.Properties.Resources.table2;
            this.pictureBoxBG.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(571, 300);
            this.pictureBoxBG.TabIndex = 3;
            this.pictureBoxBG.TabStop = false;
            this.pictureBoxBG.Tag = "dingus background";
            // 
            // pictureBoxOpponent
            // 
            this.pictureBoxOpponent.Location = new System.Drawing.Point(261, 50);
            this.pictureBoxOpponent.Name = "pictureBoxOpponent";
            this.pictureBoxOpponent.Size = new System.Drawing.Size(300, 250);
            this.pictureBoxOpponent.TabIndex = 4;
            this.pictureBoxOpponent.TabStop = false;
            this.pictureBoxOpponent.Tag = "dingus";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forfeitToolStripMenuItem,
            this.instructionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // forfeitToolStripMenuItem
            // 
            this.forfeitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forfeitMatchToolStripMenuItem});
            this.forfeitToolStripMenuItem.Name = "forfeitToolStripMenuItem";
            this.forfeitToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.forfeitToolStripMenuItem.Text = "Options";
            // 
            // forfeitMatchToolStripMenuItem
            // 
            this.forfeitMatchToolStripMenuItem.Name = "forfeitMatchToolStripMenuItem";
            this.forfeitMatchToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.forfeitMatchToolStripMenuItem.Text = "Forfeit Match";
            this.forfeitMatchToolStripMenuItem.Click += new System.EventHandler(this.forfeitMatchToolStripMenuItem_Click_1);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem});
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(412, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            // 
            // pictureBoxOpponentPreview
            // 
            this.pictureBoxOpponentPreview.Location = new System.Drawing.Point(57, 66);
            this.pictureBoxOpponentPreview.Name = "pictureBoxOpponentPreview";
            this.pictureBoxOpponentPreview.Size = new System.Drawing.Size(129, 163);
            this.pictureBoxOpponentPreview.TabIndex = 10;
            this.pictureBoxOpponentPreview.TabStop = false;
            this.pictureBoxOpponentPreview.Tag = "opponentcarddisplay";
            // 
            // pictureBoxPlayerPreview
            // 
            this.pictureBoxPlayerPreview.BackgroundImage = global::WarCardGame.Properties.Resources.Card_Select;
            this.pictureBoxPlayerPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayerPreview.Location = new System.Drawing.Point(637, 66);
            this.pictureBoxPlayerPreview.Name = "pictureBoxPlayerPreview";
            this.pictureBoxPlayerPreview.Size = new System.Drawing.Size(129, 163);
            this.pictureBoxPlayerPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayerPreview.TabIndex = 10;
            this.pictureBoxPlayerPreview.TabStop = false;
            this.pictureBoxPlayerPreview.Tag = "playercarddisplay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Opponent Previous Card:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Player Card:";
            // 
            // SelectCardTest
            // 
            this.SelectCardTest.Location = new System.Drawing.Point(664, 245);
            this.SelectCardTest.Name = "SelectCardTest";
            this.SelectCardTest.Size = new System.Drawing.Size(78, 36);
            this.SelectCardTest.TabIndex = 13;
            this.SelectCardTest.Text = "select";
            this.SelectCardTest.UseVisualStyleBackColor = true;
            this.SelectCardTest.Click += new System.EventHandler(this.SelectCardTest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "VALUE:  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "VALUE:  ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(368, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Score:";
            // 
            // pictureBoxPickACard
            // 
            this.pictureBoxPickACard.BackgroundImage = global::WarCardGame.Properties.Resources.Card_Select;
            this.pictureBoxPickACard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPickACard.Location = new System.Drawing.Point(637, 66);
            this.pictureBoxPickACard.Name = "pictureBoxPickACard";
            this.pictureBoxPickACard.Size = new System.Drawing.Size(129, 163);
            this.pictureBoxPickACard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPickACard.TabIndex = 10;
            this.pictureBoxPickACard.TabStop = false;
            this.pictureBoxPickACard.Tag = "playercarddisplay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarCardGame.Properties.Resources.table2;
            this.ClientSize = new System.Drawing.Size(799, 598);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SelectCardTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxPickACard);
            this.Controls.Add(this.pictureBoxPlayerPreview);
            this.Controls.Add(this.pictureBoxOpponentPreview);
            this.Controls.Add(this.pictureBoxOpponent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBoxBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpponentPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPickACard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListCardDeck;
        private System.Windows.Forms.ImageList imageListCardsOpponent;
        private System.Windows.Forms.ImageList imageListCardsPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBG;
        private System.Windows.Forms.PictureBox pictureBoxOpponent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem forfeitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forfeitMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxOpponentPreview;
        private System.Windows.Forms.PictureBox pictureBoxPlayerPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectCardTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxPickACard;
    }
}

