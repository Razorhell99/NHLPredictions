namespace NHLPredictions
{
    partial class PredictionSheet
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
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblHomeGoalie = new System.Windows.Forms.Label();
            this.lblAwayGoalie = new System.Windows.Forms.Label();
            this.lblHottestLast3Games = new System.Windows.Forms.Label();
            this.lblGfLast3Home = new System.Windows.Forms.Label();
            this.lblGfLast3Away = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Location = new System.Drawing.Point(32, 95);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(71, 13);
            this.lblHomeTeam.TabIndex = 0;
            this.lblHomeTeam.Text = "Home Team :";
            // 
            // lblAwayTeam
            // 
            this.lblAwayTeam.AutoSize = true;
            this.lblAwayTeam.Location = new System.Drawing.Point(291, 95);
            this.lblAwayTeam.Name = "lblAwayTeam";
            this.lblAwayTeam.Size = new System.Drawing.Size(69, 13);
            this.lblAwayTeam.TabIndex = 1;
            this.lblAwayTeam.Text = "Away Team :";
            // 
            // lblHomeGoalie
            // 
            this.lblHomeGoalie.AutoSize = true;
            this.lblHomeGoalie.Location = new System.Drawing.Point(33, 128);
            this.lblHomeGoalie.Name = "lblHomeGoalie";
            this.lblHomeGoalie.Size = new System.Drawing.Size(74, 13);
            this.lblHomeGoalie.TabIndex = 2;
            this.lblHomeGoalie.Text = "Home Goalie :";
            // 
            // lblAwayGoalie
            // 
            this.lblAwayGoalie.AutoSize = true;
            this.lblAwayGoalie.Location = new System.Drawing.Point(291, 128);
            this.lblAwayGoalie.Name = "lblAwayGoalie";
            this.lblAwayGoalie.Size = new System.Drawing.Size(72, 13);
            this.lblAwayGoalie.TabIndex = 3;
            this.lblAwayGoalie.Text = "Away Goalie :";
            // 
            // lblHottestLast3Games
            // 
            this.lblHottestLast3Games.AutoSize = true;
            this.lblHottestLast3Games.Location = new System.Drawing.Point(112, 35);
            this.lblHottestLast3Games.Name = "lblHottestLast3Games";
            this.lblHottestLast3Games.Size = new System.Drawing.Size(182, 13);
            this.lblHottestLast3Games.TabIndex = 4;
            this.lblHottestLast3Games.Text = "Hottest Offense Teams Last 3 games";
            // 
            // lblGfLast3Home
            // 
            this.lblGfLast3Home.AutoSize = true;
            this.lblGfLast3Home.Location = new System.Drawing.Point(37, 158);
            this.lblGfLast3Home.Name = "lblGfLast3Home";
            this.lblGfLast3Home.Size = new System.Drawing.Size(104, 13);
            this.lblGfLast3Home.TabIndex = 5;
            this.lblGfLast3Home.Text = "GF/G last 3 Games :";
            // 
            // lblGfLast3Away
            // 
            this.lblGfLast3Away.AutoSize = true;
            this.lblGfLast3Away.Location = new System.Drawing.Point(291, 158);
            this.lblGfLast3Away.Name = "lblGfLast3Away";
            this.lblGfLast3Away.Size = new System.Drawing.Size(104, 13);
            this.lblGfLast3Away.TabIndex = 6;
            this.lblGfLast3Away.Text = "GF/G last 3 Games :";
            // 
            // PredictionSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGfLast3Away);
            this.Controls.Add(this.lblGfLast3Home);
            this.Controls.Add(this.lblHottestLast3Games);
            this.Controls.Add(this.lblAwayGoalie);
            this.Controls.Add(this.lblHomeGoalie);
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Name = "PredictionSheet";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.Label lblHomeGoalie;
        private System.Windows.Forms.Label lblAwayGoalie;
        private System.Windows.Forms.Label lblHottestLast3Games;
        private System.Windows.Forms.Label lblGfLast3Home;
        private System.Windows.Forms.Label lblGfLast3Away;
    }
}

