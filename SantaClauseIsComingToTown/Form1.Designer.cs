using System;

namespace SantaClauseIsComingToTown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moon = new System.Windows.Forms.PictureBox();
            this.hut = new System.Windows.Forms.PictureBox();
            this.sleigh = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.snowflake1 = new System.Windows.Forms.PictureBox();
            this.snowflake = new System.Windows.Forms.PictureBox();
            this.playAgain = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).BeginInit();
            this.SuspendLayout();
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(-1, -1);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(138, 122);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 0;
            this.moon.TabStop = false;
            // 
            // hut
            // 
            this.hut.Image = ((System.Drawing.Image)(resources.GetObject("hut.Image")));
            this.hut.Location = new System.Drawing.Point(408, 226);
            this.hut.Name = "hut";
            this.hut.Size = new System.Drawing.Size(121, 112);
            this.hut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hut.TabIndex = 1;
            this.hut.TabStop = false;
            this.hut.Click += new System.EventHandler(this.hut_Click);
            // 
            // sleigh
            // 
            this.sleigh.Image = ((System.Drawing.Image)(resources.GetObject("sleigh.Image")));
            this.sleigh.Location = new System.Drawing.Point(124, 236);
            this.sleigh.Name = "sleigh";
            this.sleigh.Size = new System.Drawing.Size(213, 102);
            this.sleigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sleigh.TabIndex = 2;
            this.sleigh.TabStop = false;
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(627, 151);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(100, 187);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 3;
            this.tree.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-1, 335);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(801, 117);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.snowflake_Click);
            // 
            // snowflake1
            // 
            this.snowflake1.Image = ((System.Drawing.Image)(resources.GetObject("snowflake1.Image")));
            this.snowflake1.Location = new System.Drawing.Point(426, 12);
            this.snowflake1.Name = "snowflake1";
            this.snowflake1.Size = new System.Drawing.Size(66, 58);
            this.snowflake1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowflake1.TabIndex = 7;
            this.snowflake1.TabStop = false;
            this.snowflake1.Click += new System.EventHandler(this.snowflake_Click);
            // 
            // snowflake
            // 
            this.snowflake.Image = ((System.Drawing.Image)(resources.GetObject("snowflake.Image")));
            this.snowflake.Location = new System.Drawing.Point(233, 12);
            this.snowflake.Name = "snowflake";
            this.snowflake.Size = new System.Drawing.Size(61, 58);
            this.snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowflake.TabIndex = 9;
            this.snowflake.TabStop = false;
            this.snowflake.Click += new System.EventHandler(this.snowflake_Click);
            // 
            // playAgain
            // 
            this.playAgain.Location = new System.Drawing.Point(209, 151);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(85, 50);
            this.playAgain.TabIndex = 10;
            this.playAgain.Text = "PLAY AGAIN";
            this.playAgain.UseVisualStyleBackColor = true;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(300, 86);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(35, 13);
            this.Score.TabIndex = 11;
            this.Score.Text = "Score";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.snowflake);
            this.Controls.Add(this.snowflake1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.sleigh);
            this.Controls.Add(this.hut);
            this.Controls.Add(this.moon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox hut;
        private System.Windows.Forms.PictureBox sleigh;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox snowflake1;
        private System.Windows.Forms.PictureBox snowflake;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;

        public EventHandler button1_Click_1 { get; private set; }
    }
}

