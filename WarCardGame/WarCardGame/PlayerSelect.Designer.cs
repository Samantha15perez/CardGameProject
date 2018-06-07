namespace WarCardGame
{
    partial class PlayerSelect
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
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateNewPlayer = new System.Windows.Forms.Button();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.Font = new System.Drawing.Font("Stencil", 10F);
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 16;
            this.listBoxPlayers.Location = new System.Drawing.Point(22, 29);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(127, 180);
            this.listBoxPlayers.TabIndex = 0;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10F);
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Select A Player";
            // 
            // buttonCreateNewPlayer
            // 
            this.buttonCreateNewPlayer.Font = new System.Drawing.Font("Stencil", 10F);
            this.buttonCreateNewPlayer.Location = new System.Drawing.Point(22, 221);
            this.buttonCreateNewPlayer.Name = "buttonCreateNewPlayer";
            this.buttonCreateNewPlayer.Size = new System.Drawing.Size(127, 28);
            this.buttonCreateNewPlayer.TabIndex = 2;
            this.buttonCreateNewPlayer.Text = "New Player?";
            this.buttonCreateNewPlayer.UseVisualStyleBackColor = true;
            this.buttonCreateNewPlayer.Click += new System.EventHandler(this.buttonCreateNewPlayer_Click);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Stencil", 10F);
            this.buttonStartGame.Location = new System.Drawing.Point(436, 221);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(127, 27);
            this.buttonStartGame.TabIndex = 3;
            this.buttonStartGame.Text = "Begin";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 10F);
            this.label2.Location = new System.Drawing.Point(450, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "High Score:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Stencil", 20F);
            this.label3.Location = new System.Drawing.Point(436, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 55);
            this.label3.TabIndex = 5;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 10F);
            this.label4.Location = new System.Drawing.Point(450, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Played:";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F);
            this.label5.Location = new System.Drawing.Point(436, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 30);
            this.label5.TabIndex = 5;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 10F);
            this.label6.Location = new System.Drawing.Point(188, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Created By Samantha Perez";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::WarCardGame.Properties.Resources.PixelatedLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(143, 20);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(293, 195);
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // PlayerSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 258);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.buttonCreateNewPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "PlayerSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerSelect";
            this.Load += new System.EventHandler(this.PlayerSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateNewPlayer;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label6;
    }
}