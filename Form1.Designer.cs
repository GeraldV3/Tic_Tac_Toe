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
            ((System.ComponentModel.ISupportInitialize)(this.Start_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Start;
            this.Start_btn.Location = new System.Drawing.Point(107, 130);
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
            this.Quit_btn.Location = new System.Drawing.Point(107, 309);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(380, 100);
            this.Quit_btn.TabIndex = 1;
            this.Quit_btn.TabStop = false;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            this.Quit_btn.MouseLeave += new System.EventHandler(this.Quit_btn_MouseLeave);
            this.Quit_btn.MouseHover += new System.EventHandler(this.Quit_btn_MouseHover);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.Lobby;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Quit_btn);
            this.Controls.Add(this.Start_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Start_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quit_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Start_btn;
        private PictureBox Quit_btn;
    }
}