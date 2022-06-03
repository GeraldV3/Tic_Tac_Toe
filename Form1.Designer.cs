namespace Tic_Tac_Toe
{
    partial class Lobby
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.Start_btn = new System.Windows.Forms.PictureBox();
            this.Quit_btn = new System.Windows.Forms.PictureBox();
            this.X_Score = new System.Windows.Forms.PictureBox();
            this.Colon_X = new System.Windows.Forms.Label();
            this.Color_O = new System.Windows.Forms.Label();
            this.Score_O = new System.Windows.Forms.PictureBox();
            this.P1_Score = new System.Windows.Forms.Label();
            this.P2_Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Start_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score_O)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Start;
            this.Start_btn.Location = new System.Drawing.Point(107, 53);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(380, 100);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.TabStop = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            this.Start_btn.MouseLeave += new System.EventHandler(this.Start_btn_MouseLeave);
            this.Start_btn.MouseHover += new System.EventHandler(this.Start_btn_MouseHover);
            // 
            // Quit_btn
            // 
            this.Quit_btn.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Quit;
            this.Quit_btn.Location = new System.Drawing.Point(107, 240);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(380, 100);
            this.Quit_btn.TabIndex = 1;
            this.Quit_btn.TabStop = false;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            this.Quit_btn.MouseLeave += new System.EventHandler(this.Quit_btn_MouseLeave);
            this.Quit_btn.MouseHover += new System.EventHandler(this.Quit_btn_MouseHover);
            // 
            // X_Score
            // 
            this.X_Score.BackColor = System.Drawing.Color.Transparent;
            this.X_Score.Image = global::Tic_Tac_Toe.Properties.Resources.Player_11;
            this.X_Score.Location = new System.Drawing.Point(76, 372);
            this.X_Score.Name = "X_Score";
            this.X_Score.Size = new System.Drawing.Size(125, 68);
            this.X_Score.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.X_Score.TabIndex = 2;
            this.X_Score.TabStop = false;
            this.X_Score.Click += new System.EventHandler(this.X_Score_Click);
            // 
            // Colon_X
            // 
            this.Colon_X.AutoSize = true;
            this.Colon_X.BackColor = System.Drawing.Color.Transparent;
            this.Colon_X.Font = new System.Drawing.Font("Athletic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Colon_X.ForeColor = System.Drawing.Color.Red;
            this.Colon_X.Location = new System.Drawing.Point(98, 448);
            this.Colon_X.Name = "Colon_X";
            this.Colon_X.Size = new System.Drawing.Size(47, 61);
            this.Colon_X.TabIndex = 3;
            this.Colon_X.Text = ":";
            // 
            // Color_O
            // 
            this.Color_O.AutoSize = true;
            this.Color_O.BackColor = System.Drawing.Color.Transparent;
            this.Color_O.Font = new System.Drawing.Font("Athletic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Color_O.ForeColor = System.Drawing.Color.Red;
            this.Color_O.Location = new System.Drawing.Point(414, 439);
            this.Color_O.Name = "Color_O";
            this.Color_O.Size = new System.Drawing.Size(47, 61);
            this.Color_O.TabIndex = 5;
            this.Color_O.Text = ":";
            // 
            // Score_O
            // 
            this.Score_O.BackColor = System.Drawing.Color.Transparent;
            this.Score_O.Image = global::Tic_Tac_Toe.Properties.Resources.Player_22;
            this.Score_O.Location = new System.Drawing.Point(384, 363);
            this.Score_O.Name = "Score_O";
            this.Score_O.Size = new System.Drawing.Size(125, 68);
            this.Score_O.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Score_O.TabIndex = 4;
            this.Score_O.TabStop = false;
            this.Score_O.Click += new System.EventHandler(this.Score_O_Click);
            // 
            // P1_Score
            // 
            this.P1_Score.AutoSize = true;
            this.P1_Score.BackColor = System.Drawing.Color.Transparent;
            this.P1_Score.Font = new System.Drawing.Font("Athletic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.P1_Score.ForeColor = System.Drawing.Color.Red;
            this.P1_Score.Location = new System.Drawing.Point(145, 448);
            this.P1_Score.Name = "P1_Score";
            this.P1_Score.Size = new System.Drawing.Size(0, 61);
            this.P1_Score.TabIndex = 6;
            // 
            // P2_Score
            // 
            this.P2_Score.AutoSize = true;
            this.P2_Score.BackColor = System.Drawing.Color.Transparent;
            this.P2_Score.Font = new System.Drawing.Font("Athletic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.P2_Score.ForeColor = System.Drawing.Color.Red;
            this.P2_Score.Location = new System.Drawing.Point(450, 438);
            this.P2_Score.Name = "P2_Score";
            this.P2_Score.Size = new System.Drawing.Size(0, 61);
            this.P2_Score.TabIndex = 7;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Lobby;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.X_Score);
            this.Controls.Add(this.P2_Score);
            this.Controls.Add(this.P1_Score);
            this.Controls.Add(this.Color_O);
            this.Controls.Add(this.Score_O);
            this.Controls.Add(this.Colon_X);
            this.Controls.Add(this.Quit_btn);
            this.Controls.Add(this.Start_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Start_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Score_O)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Start_btn;
        private PictureBox Quit_btn;
        private PictureBox X_Score;
        private Label Colon_X;
        private Label Color_O;
        private PictureBox Score_O;
        private Label P1_Score;
        private Label P2_Score;
    }
}