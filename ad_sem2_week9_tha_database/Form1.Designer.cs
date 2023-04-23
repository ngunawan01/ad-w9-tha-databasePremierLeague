namespace ad_sem2_week9_tha_database
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelGoalsScored = new System.Windows.Forms.Label();
            this.labelRedCards = new System.Windows.Forms.Label();
            this.labelPlayingPos = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelPlayerTeam = new System.Windows.Forms.Label();
            this.labelPenaltyMissed = new System.Windows.Forms.Label();
            this.labelAnswerPlayerName = new System.Windows.Forms.Label();
            this.labelAnswerPlayerTeam = new System.Windows.Forms.Label();
            this.labelAnswerPosition = new System.Windows.Forms.Label();
            this.labelAnswerNationality = new System.Windows.Forms.Label();
            this.labelAnswerPlayingPos = new System.Windows.Forms.Label();
            this.labelAnswerRedCards = new System.Windows.Forms.Label();
            this.labelAnswerGoalsScored = new System.Windows.Forms.Label();
            this.labelAnswerPenaltyMissed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxMatch2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMatch = new System.Windows.Forms.Label();
            this.comboBoxTeam2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelYellowCard = new System.Windows.Forms.Label();
            this.labelAnswerYellowCard = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // showMatchDetailsToolStripMenuItem
            // 
            this.showMatchDetailsToolStripMenuItem.Name = "showMatchDetailsToolStripMenuItem";
            this.showMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.showMatchDetailsToolStripMenuItem.Text = "Show Match Details";
            this.showMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_Click);
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam.Location = new System.Drawing.Point(15, 21);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(56, 20);
            this.labelTeam.TabIndex = 1;
            this.labelTeam.Text = "Team:";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(217, 21);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(61, 20);
            this.labelPlayer.TabIndex = 2;
            this.labelPlayer.Text = "Player:";
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(77, 21);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTeam.TabIndex = 3;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(284, 21);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPlayer.TabIndex = 4;
            this.comboBoxPlayer.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayer_SelectedIndexChanged);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerName.Location = new System.Drawing.Point(15, 71);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(110, 20);
            this.labelPlayerName.TabIndex = 5;
            this.labelPlayerName.Text = "Player Name:";
            // 
            // labelGoalsScored
            // 
            this.labelGoalsScored.AutoSize = true;
            this.labelGoalsScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalsScored.Location = new System.Drawing.Point(15, 247);
            this.labelGoalsScored.Name = "labelGoalsScored";
            this.labelGoalsScored.Size = new System.Drawing.Size(116, 20);
            this.labelGoalsScored.TabIndex = 6;
            this.labelGoalsScored.Text = "Goals Scored:";
            // 
            // labelRedCards
            // 
            this.labelRedCards.AutoSize = true;
            this.labelRedCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedCards.Location = new System.Drawing.Point(15, 218);
            this.labelRedCards.Name = "labelRedCards";
            this.labelRedCards.Size = new System.Drawing.Size(94, 20);
            this.labelRedCards.TabIndex = 7;
            this.labelRedCards.Text = "Red Cards:";
            // 
            // labelPlayingPos
            // 
            this.labelPlayingPos.AutoSize = true;
            this.labelPlayingPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayingPos.Location = new System.Drawing.Point(15, 188);
            this.labelPlayingPos.Name = "labelPlayingPos";
            this.labelPlayingPos.Size = new System.Drawing.Size(102, 20);
            this.labelPlayingPos.TabIndex = 8;
            this.labelPlayingPos.Text = "Playing Pos:";
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.Location = new System.Drawing.Point(15, 161);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(92, 20);
            this.labelNationality.TabIndex = 9;
            this.labelNationality.Text = "Nationality:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(15, 132);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(74, 20);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Position:";
            // 
            // labelPlayerTeam
            // 
            this.labelPlayerTeam.AutoSize = true;
            this.labelPlayerTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerTeam.Location = new System.Drawing.Point(15, 102);
            this.labelPlayerTeam.Name = "labelPlayerTeam";
            this.labelPlayerTeam.Size = new System.Drawing.Size(108, 20);
            this.labelPlayerTeam.TabIndex = 11;
            this.labelPlayerTeam.Text = "Player Team:";
            // 
            // labelPenaltyMissed
            // 
            this.labelPenaltyMissed.AutoSize = true;
            this.labelPenaltyMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenaltyMissed.Location = new System.Drawing.Point(15, 276);
            this.labelPenaltyMissed.Name = "labelPenaltyMissed";
            this.labelPenaltyMissed.Size = new System.Drawing.Size(128, 20);
            this.labelPenaltyMissed.TabIndex = 12;
            this.labelPenaltyMissed.Text = "Penalty Missed:";
            // 
            // labelAnswerPlayerName
            // 
            this.labelAnswerPlayerName.AutoSize = true;
            this.labelAnswerPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerPlayerName.Location = new System.Drawing.Point(151, 71);
            this.labelAnswerPlayerName.Name = "labelAnswerPlayerName";
            this.labelAnswerPlayerName.Size = new System.Drawing.Size(54, 20);
            this.labelAnswerPlayerName.TabIndex = 13;
            this.labelAnswerPlayerName.Text = "_____";
            // 
            // labelAnswerPlayerTeam
            // 
            this.labelAnswerPlayerTeam.AutoSize = true;
            this.labelAnswerPlayerTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerPlayerTeam.Location = new System.Drawing.Point(151, 102);
            this.labelAnswerPlayerTeam.Name = "labelAnswerPlayerTeam";
            this.labelAnswerPlayerTeam.Size = new System.Drawing.Size(54, 20);
            this.labelAnswerPlayerTeam.TabIndex = 14;
            this.labelAnswerPlayerTeam.Text = "_____";
            // 
            // labelAnswerPosition
            // 
            this.labelAnswerPosition.AutoSize = true;
            this.labelAnswerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerPosition.Location = new System.Drawing.Point(151, 132);
            this.labelAnswerPosition.Name = "labelAnswerPosition";
            this.labelAnswerPosition.Size = new System.Drawing.Size(54, 20);
            this.labelAnswerPosition.TabIndex = 15;
            this.labelAnswerPosition.Text = "_____";
            // 
            // labelAnswerNationality
            // 
            this.labelAnswerNationality.AutoSize = true;
            this.labelAnswerNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerNationality.Location = new System.Drawing.Point(151, 161);
            this.labelAnswerNationality.Name = "labelAnswerNationality";
            this.labelAnswerNationality.Size = new System.Drawing.Size(54, 20);
            this.labelAnswerNationality.TabIndex = 16;
            this.labelAnswerNationality.Text = "_____";
            // 
            // labelAnswerPlayingPos
            // 
            this.labelAnswerPlayingPos.AutoSize = true;
            this.labelAnswerPlayingPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerPlayingPos.Location = new System.Drawing.Point(151, 188);
            this.labelAnswerPlayingPos.Name = "labelAnswerPlayingPos";
            this.labelAnswerPlayingPos.Size = new System.Drawing.Size(54, 20);
            this.labelAnswerPlayingPos.TabIndex = 17;
            this.labelAnswerPlayingPos.Text = "_____";
            // 
            // labelAnswerRedCards
            // 
            this.labelAnswerRedCards.AutoSize = true;
            this.labelAnswerRedCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerRedCards.Location = new System.Drawing.Point(151, 218);
            this.labelAnswerRedCards.Name = "labelAnswerRedCards";
            this.labelAnswerRedCards.Size = new System.Drawing.Size(54, 20);
            this.labelAnswerRedCards.TabIndex = 18;
            this.labelAnswerRedCards.Text = "_____";
            // 
            // labelAnswerGoalsScored
            // 
            this.labelAnswerGoalsScored.AutoSize = true;
            this.labelAnswerGoalsScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerGoalsScored.Location = new System.Drawing.Point(151, 247);
            this.labelAnswerGoalsScored.Name = "labelAnswerGoalsScored";
            this.labelAnswerGoalsScored.Size = new System.Drawing.Size(54, 20);
            this.labelAnswerGoalsScored.TabIndex = 19;
            this.labelAnswerGoalsScored.Text = "_____";
            // 
            // labelAnswerPenaltyMissed
            // 
            this.labelAnswerPenaltyMissed.AutoSize = true;
            this.labelAnswerPenaltyMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerPenaltyMissed.Location = new System.Drawing.Point(152, 276);
            this.labelAnswerPenaltyMissed.Name = "labelAnswerPenaltyMissed";
            this.labelAnswerPenaltyMissed.Size = new System.Drawing.Size(54, 20);
            this.labelAnswerPenaltyMissed.TabIndex = 20;
            this.labelAnswerPenaltyMissed.Text = "_____";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAnswerYellowCard);
            this.panel1.Controls.Add(this.labelYellowCard);
            this.panel1.Controls.Add(this.comboBoxPlayer);
            this.panel1.Controls.Add(this.labelAnswerPenaltyMissed);
            this.panel1.Controls.Add(this.labelTeam);
            this.panel1.Controls.Add(this.labelAnswerGoalsScored);
            this.panel1.Controls.Add(this.labelPlayer);
            this.panel1.Controls.Add(this.labelAnswerRedCards);
            this.panel1.Controls.Add(this.comboBoxTeam);
            this.panel1.Controls.Add(this.labelAnswerPlayingPos);
            this.panel1.Controls.Add(this.labelPlayerName);
            this.panel1.Controls.Add(this.labelAnswerNationality);
            this.panel1.Controls.Add(this.labelGoalsScored);
            this.panel1.Controls.Add(this.labelAnswerPosition);
            this.panel1.Controls.Add(this.labelRedCards);
            this.panel1.Controls.Add(this.labelAnswerPlayerTeam);
            this.panel1.Controls.Add(this.labelPlayingPos);
            this.panel1.Controls.Add(this.labelAnswerPlayerName);
            this.panel1.Controls.Add(this.labelNationality);
            this.panel1.Controls.Add(this.labelPenaltyMissed);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.labelPlayerTeam);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 393);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.comboBoxMatch2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelMatch);
            this.panel2.Controls.Add(this.comboBoxTeam2);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 393);
            this.panel2.TabIndex = 21;
            // 
            // comboBoxMatch2
            // 
            this.comboBoxMatch2.FormattingEnabled = true;
            this.comboBoxMatch2.Location = new System.Drawing.Point(305, 14);
            this.comboBoxMatch2.Name = "comboBoxMatch2";
            this.comboBoxMatch2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMatch2.TabIndex = 24;
            this.comboBoxMatch2.SelectedIndexChanged += new System.EventHandler(this.comboBoxMatch2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Team:";
            // 
            // labelMatch
            // 
            this.labelMatch.AutoSize = true;
            this.labelMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatch.Location = new System.Drawing.Point(217, 14);
            this.labelMatch.Name = "labelMatch";
            this.labelMatch.Size = new System.Drawing.Size(82, 20);
            this.labelMatch.TabIndex = 22;
            this.labelMatch.Text = "Match ID:";
            // 
            // comboBoxTeam2
            // 
            this.comboBoxTeam2.FormattingEnabled = true;
            this.comboBoxTeam2.Location = new System.Drawing.Point(77, 14);
            this.comboBoxTeam2.Name = "comboBoxTeam2";
            this.comboBoxTeam2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTeam2.TabIndex = 23;
            this.comboBoxTeam2.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam2_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 326);
            this.dataGridView1.TabIndex = 25;
            // 
            // labelYellowCard
            // 
            this.labelYellowCard.AutoSize = true;
            this.labelYellowCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYellowCard.Location = new System.Drawing.Point(15, 306);
            this.labelYellowCard.Name = "labelYellowCard";
            this.labelYellowCard.Size = new System.Drawing.Size(103, 20);
            this.labelYellowCard.TabIndex = 22;
            this.labelYellowCard.Text = "Yellow Card:";
            // 
            // labelAnswerYellowCard
            // 
            this.labelAnswerYellowCard.AutoSize = true;
            this.labelAnswerYellowCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerYellowCard.Location = new System.Drawing.Point(152, 306);
            this.labelAnswerYellowCard.Name = "labelAnswerYellowCard";
            this.labelAnswerYellowCard.Size = new System.Drawing.Size(54, 20);
            this.labelAnswerYellowCard.TabIndex = 23;
            this.labelAnswerYellowCard.Text = "_____";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelGoalsScored;
        private System.Windows.Forms.Label labelRedCards;
        private System.Windows.Forms.Label labelPlayingPos;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelPlayerTeam;
        private System.Windows.Forms.Label labelPenaltyMissed;
        private System.Windows.Forms.Label labelAnswerPlayerName;
        private System.Windows.Forms.Label labelAnswerPlayerTeam;
        private System.Windows.Forms.Label labelAnswerPosition;
        private System.Windows.Forms.Label labelAnswerNationality;
        private System.Windows.Forms.Label labelAnswerPlayingPos;
        private System.Windows.Forms.Label labelAnswerRedCards;
        private System.Windows.Forms.Label labelAnswerGoalsScored;
        private System.Windows.Forms.Label labelAnswerPenaltyMissed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxMatch2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMatch;
        private System.Windows.Forms.ComboBox comboBoxTeam2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAnswerYellowCard;
        private System.Windows.Forms.Label labelYellowCard;
    }
}

