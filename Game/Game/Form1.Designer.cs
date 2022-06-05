
namespace Game
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
            this.components = new System.ComponentModel.Container();
            this.ScoreText = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.BotomPipe = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.AccessibleDescription = "ScoreText";
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Khaki;
            this.ScoreText.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(117, 457);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(133, 44);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score:0";
            // 
            // Ground
            // 
            this.Ground.AccessibleDescription = "Ground";
            this.Ground.Image = global::Game.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-23, 446);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(658, 64);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // BotomPipe
            // 
            this.BotomPipe.AccessibleDescription = "BotomPipe";
            this.BotomPipe.Image = global::Game.Properties.Resources.pipe;
            this.BotomPipe.Location = new System.Drawing.Point(338, 320);
            this.BotomPipe.Name = "BotomPipe";
            this.BotomPipe.Size = new System.Drawing.Size(100, 169);
            this.BotomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotomPipe.TabIndex = 2;
            this.BotomPipe.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.AccessibleDescription = "FlappyBird";
            this.FlappyBird.Image = global::Game.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(-4, 191);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(100, 71);
            this.FlappyBird.TabIndex = 1;
            this.FlappyBird.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.AccessibleDescription = "PipeTop";
            this.PipeTop.Image = global::Game.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(492, -47);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(100, 160);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            // 
            // GameTime
            // 
            this.GameTime.Enabled = true;
            this.GameTime.Interval = 20;
            this.GameTime.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(604, 501);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.BotomPipe);
            this.Controls.Add(this.PipeTop);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamkeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox BotomPipe;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

