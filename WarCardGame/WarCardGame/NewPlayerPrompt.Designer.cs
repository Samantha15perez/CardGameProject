namespace WarCardGame
{
    partial class NewPlayerPrompt
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewPlayer = new System.Windows.Forms.TextBox();
            this.buttonNewPlayer = new System.Windows.Forms.Button();
            this.buttonPrevForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10F);
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your name.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNewPlayer
            // 
            this.textBoxNewPlayer.Font = new System.Drawing.Font("Stencil", 10F);
            this.textBoxNewPlayer.Location = new System.Drawing.Point(31, 29);
            this.textBoxNewPlayer.Name = "textBoxNewPlayer";
            this.textBoxNewPlayer.Size = new System.Drawing.Size(176, 23);
            this.textBoxNewPlayer.TabIndex = 1;
            // 
            // buttonNewPlayer
            // 
            this.buttonNewPlayer.Font = new System.Drawing.Font("Stencil", 10F);
            this.buttonNewPlayer.Location = new System.Drawing.Point(31, 65);
            this.buttonNewPlayer.Name = "buttonNewPlayer";
            this.buttonNewPlayer.Size = new System.Drawing.Size(58, 25);
            this.buttonNewPlayer.TabIndex = 2;
            this.buttonNewPlayer.Text = "OK";
            this.buttonNewPlayer.UseVisualStyleBackColor = true;
            this.buttonNewPlayer.Click += new System.EventHandler(this.buttonNewPlayer_Click);
            // 
            // buttonPrevForm
            // 
            this.buttonPrevForm.Font = new System.Drawing.Font("Stencil", 10F);
            this.buttonPrevForm.Location = new System.Drawing.Point(149, 65);
            this.buttonPrevForm.Name = "buttonPrevForm";
            this.buttonPrevForm.Size = new System.Drawing.Size(58, 25);
            this.buttonPrevForm.TabIndex = 3;
            this.buttonPrevForm.Text = "Back";
            this.buttonPrevForm.UseVisualStyleBackColor = true;
            this.buttonPrevForm.Click += new System.EventHandler(this.buttonPrevForm_Click);
            // 
            // NewPlayerPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 109);
            this.Controls.Add(this.buttonPrevForm);
            this.Controls.Add(this.buttonNewPlayer);
            this.Controls.Add(this.textBoxNewPlayer);
            this.Controls.Add(this.label1);
            this.Name = "NewPlayerPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPlayerPrompt";
            this.Load += new System.EventHandler(this.NewPlayerPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewPlayer;
        private System.Windows.Forms.Button buttonNewPlayer;
        private System.Windows.Forms.Button buttonPrevForm;
    }
}