namespace Mini_car_games
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.scoreText = new System.Windows.Forms.Label();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.endGame1 = new System.Windows.Forms.Label();
            this.endGame2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreText.Location = new System.Drawing.Point(0, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(107, 25);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // flappybird
            // 
            this.flappybird.Image = global::Mini_car_games.Properties.Resources.bird;
            this.flappybird.Location = new System.Drawing.Point(27, 166);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(80, 60);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Mini_car_games.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-5, 492);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(508, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::Mini_car_games.Properties.Resources.pipe;
            this.pipebottom.Location = new System.Drawing.Point(251, 330);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(82, 200);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 2;
            this.pipebottom.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::Mini_car_games.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(421, -20);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(82, 200);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 1;
            this.pipetop.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // endGame1
            // 
            this.endGame1.AutoSize = true;
            this.endGame1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endGame1.ForeColor = System.Drawing.Color.Red;
            this.endGame1.Location = new System.Drawing.Point(136, 195);
            this.endGame1.Name = "endGame1";
            this.endGame1.Size = new System.Drawing.Size(234, 42);
            this.endGame1.TabIndex = 5;
            this.endGame1.Text = "Game Over";
            // 
            // endGame2
            // 
            this.endGame2.AutoSize = true;
            this.endGame2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endGame2.Location = new System.Drawing.Point(120, 250);
            this.endGame2.Name = "endGame2";
            this.endGame2.Size = new System.Drawing.Size(84, 25);
            this.endGame2.TabIndex = 6;
            this.endGame2.Text = "label1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(498, 542);
            this.Controls.Add(this.endGame2);
            this.Controls.Add(this.endGame1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.pipetop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Flapping Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label endGame1;
        private System.Windows.Forms.Label endGame2;
    }
}