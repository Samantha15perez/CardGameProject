namespace WarCardGame
{
    partial class ChooseOpponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseOpponent));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxChar4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxChar3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxChar2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxChar1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.imageListOpponent = new System.Windows.Forms.ImageList(this.components);
            this.buttonStartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please, choose your opponent:";
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(298, 230);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(75, 30);
            this.buttonRandomize.TabIndex = 3;
            this.buttonRandomize.Text = "Random";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(60, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 30);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBoxChar4
            // 
            this.pictureBoxChar4.Image = global::WarCardGame.Properties.Resources.op4;
            this.pictureBoxChar4.Location = new System.Drawing.Point(379, 138);
            this.pictureBoxChar4.Name = "pictureBoxChar4";
            this.pictureBoxChar4.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxChar4.TabIndex = 2;
            this.pictureBoxChar4.TabStop = false;
            this.pictureBoxChar4.Click += new System.EventHandler(this.pictureBoxChar4_Click);
            // 
            // pictureBoxChar3
            // 
            this.pictureBoxChar3.Image = global::WarCardGame.Properties.Resources.op3;
            this.pictureBoxChar3.Location = new System.Drawing.Point(298, 138);
            this.pictureBoxChar3.Name = "pictureBoxChar3";
            this.pictureBoxChar3.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxChar3.TabIndex = 2;
            this.pictureBoxChar3.TabStop = false;
            this.pictureBoxChar3.Click += new System.EventHandler(this.pictureBoxChar3_Click);
            // 
            // pictureBoxChar2
            // 
            this.pictureBoxChar2.Image = global::WarCardGame.Properties.Resources.op2;
            this.pictureBoxChar2.Location = new System.Drawing.Point(379, 57);
            this.pictureBoxChar2.Name = "pictureBoxChar2";
            this.pictureBoxChar2.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxChar2.TabIndex = 2;
            this.pictureBoxChar2.TabStop = false;
            this.pictureBoxChar2.Click += new System.EventHandler(this.pictureBoxChar2_Click);
            // 
            // pictureBoxChar1
            // 
            this.pictureBoxChar1.BackgroundImage = global::WarCardGame.Properties.Resources.op1;
            this.pictureBoxChar1.Location = new System.Drawing.Point(298, 57);
            this.pictureBoxChar1.Name = "pictureBoxChar1";
            this.pictureBoxChar1.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxChar1.TabIndex = 2;
            this.pictureBoxChar1.TabStop = false;
            this.pictureBoxChar1.Click += new System.EventHandler(this.pictureBoxChar1_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(30, 57);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(220, 156);
            this.pictureBoxPreview.TabIndex = 1;
            this.pictureBoxPreview.TabStop = false;
            // 
            // imageListOpponent
            // 
            this.imageListOpponent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListOpponent.ImageStream")));
            this.imageListOpponent.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListOpponent.Images.SetKeyName(0, "op1prev.png");
            this.imageListOpponent.Images.SetKeyName(1, "op2prev.png");
            this.imageListOpponent.Images.SetKeyName(2, "op3prev.png");
            this.imageListOpponent.Images.SetKeyName(3, "op4prev.png");
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(379, 230);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(75, 30);
            this.buttonStartGame.TabIndex = 5;
            this.buttonStartGame.Text = "START";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // ChooseOpponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 288);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.pictureBoxChar4);
            this.Controls.Add(this.pictureBoxChar3);
            this.Controls.Add(this.pictureBoxChar2);
            this.Controls.Add(this.pictureBoxChar1);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.label1);
            this.Name = "ChooseOpponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseOpponent";
            this.Load += new System.EventHandler(this.ChooseOpponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.PictureBox pictureBoxChar1;
        private System.Windows.Forms.PictureBox pictureBoxChar2;
        private System.Windows.Forms.PictureBox pictureBoxChar3;
        private System.Windows.Forms.PictureBox pictureBoxChar4;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageListOpponent;
        private System.Windows.Forms.Button buttonStartGame;
    }
}