namespace BombermanMultiplayer
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnLocalGame = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLocalGame
            // 
            this.btnLocalGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLocalGame.AutoSize = true;
            this.btnLocalGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalGame.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnLocalGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLocalGame.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLocalGame.Location = new System.Drawing.Point(1, 198);
            this.btnLocalGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocalGame.Name = "btnLocalGame";
            this.btnLocalGame.Size = new System.Drawing.Size(403, 65);
            this.btnLocalGame.TabIndex = 0;
            this.btnLocalGame.Text = "Начать игру";
            this.btnLocalGame.UseVisualStyleBackColor = true;
            this.btnLocalGame.Click += new System.EventHandler(this.btnLocalGame_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Silver;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTitle.Location = new System.Drawing.Point(171, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(233, 50);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Игровая программа \r\n«Bomberman»";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(402, 260);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnLocalGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalGame;
        private System.Windows.Forms.Label lbTitle;
    }
}