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
            this.pictureBoxCardStack = new System.Windows.Forms.PictureBox();
            this.imageListCardsOpponent = new System.Windows.Forms.ImageList(this.components);
            this.imageListCardsPlayer = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardStack)).BeginInit();
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
            // pictureBoxCardStack
            // 
            this.pictureBoxCardStack.Image = global::WarCardGame.Properties.Resources.RedCard_stack;
            this.pictureBoxCardStack.Location = new System.Drawing.Point(588, 309);
            this.pictureBoxCardStack.Name = "pictureBoxCardStack";
            this.pictureBoxCardStack.Size = new System.Drawing.Size(70, 68);
            this.pictureBoxCardStack.TabIndex = 1;
            this.pictureBoxCardStack.TabStop = false;
            // 
            // imageListCardsOpponent
            // 
            this.imageListCardsOpponent.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListCardsOpponent.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListCardsOpponent.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListCardsPlayer
            // 
            this.imageListCardsPlayer.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListCardsPlayer.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListCardsPlayer.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarCardGame.Properties.Resources.table_bg;
            this.ClientSize = new System.Drawing.Size(792, 597);
            this.Controls.Add(this.pictureBoxCardStack);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardStack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListCardDeck;
        private System.Windows.Forms.PictureBox pictureBoxCardStack;
        private System.Windows.Forms.ImageList imageListCardsOpponent;
        private System.Windows.Forms.ImageList imageListCardsPlayer;
    }
}

