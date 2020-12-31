namespace Mini_car_games
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.points = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.PictureBox();
            this.bar3 = new System.Windows.Forms.PictureBox();
            this.bar2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.bar1 = new System.Windows.Forms.PictureBox();
            this.restart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.over)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.BackColor = System.Drawing.Color.Moccasin;
            this.points.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.points.ForeColor = System.Drawing.Color.Red;
            this.points.Location = new System.Drawing.Point(-8, -6);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(46, 45);
            this.points.TabIndex = 3;
            this.points.Text = "0";
            // 
            // over
            // 
            this.over.Image = global::Mini_car_games.Properties.Resources.unnamed;
            this.over.Location = new System.Drawing.Point(76, -6);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(484, 292);
            this.over.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.over.TabIndex = 4;
            this.over.TabStop = false;
            // 
            // bar3
            // 
            this.bar3.BackColor = System.Drawing.Color.Green;
            this.bar3.Location = new System.Drawing.Point(405, 42);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(207, 39);
            this.bar3.TabIndex = 2;
            this.bar3.TabStop = false;
            // 
            // bar2
            // 
            this.bar2.BackColor = System.Drawing.Color.Blue;
            this.bar2.Location = new System.Drawing.Point(240, 42);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(165, 39);
            this.bar2.TabIndex = 1;
            this.bar2.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Red;
            this.player.Location = new System.Drawing.Point(12, 358);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(84, 26);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.BackColor = System.Drawing.Color.Red;
            this.bar1.Location = new System.Drawing.Point(0, 42);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(243, 39);
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.BackColor = System.Drawing.Color.White;
            this.restart.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.ForeColor = System.Drawing.Color.DarkOrange;
            this.restart.Location = new System.Drawing.Point(81, 276);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(479, 45);
            this.restart.TabIndex = 5;
            this.restart.Text = "Press Enter to Restart";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 396);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.over);
            this.Controls.Add(this.points);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Color Switch";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.over)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bar1;
        private System.Windows.Forms.PictureBox bar2;
        private System.Windows.Forms.PictureBox bar3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.PictureBox over;
        private System.Windows.Forms.Label restart;
    }
}