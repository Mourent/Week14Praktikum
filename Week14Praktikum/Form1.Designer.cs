
namespace Week14Praktikum
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
            this.btnKanan = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.labelWD = new System.Windows.Forms.Label();
            this.labelTopScore = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelOutputWD = new System.Windows.Forms.Label();
            this.labelOutputTS = new System.Windows.Forms.Label();
            this.labelOuputStadium = new System.Windows.Forms.Label();
            this.labelOutputManager = new System.Windows.Forms.Label();
            this.labelOutputTeam = new System.Windows.Forms.Label();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKanan
            // 
            this.btnKanan.Location = new System.Drawing.Point(314, 33);
            this.btnKanan.Name = "btnKanan";
            this.btnKanan.Size = new System.Drawing.Size(75, 40);
            this.btnKanan.TabIndex = 7;
            this.btnKanan.Text = ">>";
            this.btnKanan.UseVisualStyleBackColor = true;
            this.btnKanan.Click += new System.EventHandler(this.btnKanan_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(217, 33);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 40);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(120, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(29, 33);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 40);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // labelWD
            // 
            this.labelWD.AutoSize = true;
            this.labelWD.Location = new System.Drawing.Point(26, 246);
            this.labelWD.Name = "labelWD";
            this.labelWD.Size = new System.Drawing.Size(89, 13);
            this.labelWD.TabIndex = 52;
            this.labelWD.Text = "Worst Discipline :";
            // 
            // labelTopScore
            // 
            this.labelTopScore.AutoSize = true;
            this.labelTopScore.Location = new System.Drawing.Point(49, 215);
            this.labelTopScore.Name = "labelTopScore";
            this.labelTopScore.Size = new System.Drawing.Size(66, 13);
            this.labelTopScore.TabIndex = 51;
            this.labelTopScore.Text = "Top Scorer :";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(64, 184);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(51, 13);
            this.labelStadium.TabIndex = 50;
            this.labelStadium.Text = "Stadium :";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(60, 147);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(55, 13);
            this.labelManager.TabIndex = 49;
            this.labelManager.Text = "Manager :";
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(44, 116);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(71, 13);
            this.labelTeam.TabIndex = 48;
            this.labelTeam.Text = "Team Name :";
            // 
            // labelOutputWD
            // 
            this.labelOutputWD.AutoSize = true;
            this.labelOutputWD.Location = new System.Drawing.Point(128, 246);
            this.labelOutputWD.Name = "labelOutputWD";
            this.labelOutputWD.Size = new System.Drawing.Size(34, 13);
            this.labelOutputWD.TabIndex = 58;
            this.labelOutputWD.Text = "Team";
            // 
            // labelOutputTS
            // 
            this.labelOutputTS.AutoSize = true;
            this.labelOutputTS.Location = new System.Drawing.Point(128, 215);
            this.labelOutputTS.Name = "labelOutputTS";
            this.labelOutputTS.Size = new System.Drawing.Size(56, 13);
            this.labelOutputTS.TabIndex = 57;
            this.labelOutputTS.Text = "Nationality";
            // 
            // labelOuputStadium
            // 
            this.labelOuputStadium.AutoSize = true;
            this.labelOuputStadium.Location = new System.Drawing.Point(128, 184);
            this.labelOuputStadium.Name = "labelOuputStadium";
            this.labelOuputStadium.Size = new System.Drawing.Size(54, 13);
            this.labelOuputStadium.TabIndex = 56;
            this.labelOuputStadium.Text = "Birth Date";
            // 
            // labelOutputManager
            // 
            this.labelOutputManager.AutoSize = true;
            this.labelOutputManager.Location = new System.Drawing.Point(128, 147);
            this.labelOutputManager.Name = "labelOutputManager";
            this.labelOutputManager.Size = new System.Drawing.Size(67, 13);
            this.labelOutputManager.TabIndex = 55;
            this.labelOutputManager.Text = "Player Name";
            // 
            // labelOutputTeam
            // 
            this.labelOutputTeam.AutoSize = true;
            this.labelOutputTeam.Location = new System.Drawing.Point(128, 116);
            this.labelOutputTeam.Name = "labelOutputTeam";
            this.labelOutputTeam.Size = new System.Drawing.Size(48, 13);
            this.labelOutputTeam.TabIndex = 54;
            this.labelOutputTeam.Text = "Player Id";
            // 
            // dgvMatch
            // 
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Location = new System.Drawing.Point(29, 288);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.Size = new System.Drawing.Size(360, 150);
            this.dgvMatch.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.dgvMatch);
            this.Controls.Add(this.labelOutputWD);
            this.Controls.Add(this.labelOutputTS);
            this.Controls.Add(this.labelOuputStadium);
            this.Controls.Add(this.labelOutputManager);
            this.Controls.Add(this.labelOutputTeam);
            this.Controls.Add(this.labelWD);
            this.Controls.Add(this.labelTopScore);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.btnKanan);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrevious);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKanan;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label labelWD;
        private System.Windows.Forms.Label labelTopScore;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelOutputWD;
        private System.Windows.Forms.Label labelOutputTS;
        private System.Windows.Forms.Label labelOuputStadium;
        private System.Windows.Forms.Label labelOutputManager;
        private System.Windows.Forms.Label labelOutputTeam;
        private System.Windows.Forms.DataGridView dgvMatch;
    }
}

