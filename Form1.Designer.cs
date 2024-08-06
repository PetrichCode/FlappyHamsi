namespace FlappyHamsi
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            hamsi = new PictureBox();
            boruUst = new PictureBox();
            boruAlt = new PictureBox();
            zemin = new PictureBox();
            skor = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ustsınır = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hamsi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruUst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ustsınır).BeginInit();
            SuspendLayout();
            // 
            // hamsi
            // 
            hamsi.Image = (Image)resources.GetObject("hamsi.Image");
            hamsi.Location = new Point(24, 197);
            hamsi.Name = "hamsi";
            hamsi.Size = new Size(120, 55);
            hamsi.SizeMode = PictureBoxSizeMode.StretchImage;
            hamsi.TabIndex = 0;
            hamsi.TabStop = false;
            // 
            // boruUst
            // 
            boruUst.Image = (Image)resources.GetObject("boruUst.Image");
            boruUst.Location = new Point(493, -6);
            boruUst.Name = "boruUst";
            boruUst.Size = new Size(57, 133);
            boruUst.SizeMode = PictureBoxSizeMode.StretchImage;
            boruUst.TabIndex = 1;
            boruUst.TabStop = false;
            // 
            // boruAlt
            // 
            boruAlt.Image = (Image)resources.GetObject("boruAlt.Image");
            boruAlt.Location = new Point(416, 325);
            boruAlt.Name = "boruAlt";
            boruAlt.Size = new Size(57, 136);
            boruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            boruAlt.TabIndex = 2;
            boruAlt.TabStop = false;
            // 
            // zemin
            // 
            zemin.Image = (Image)resources.GetObject("zemin.Image");
            zemin.Location = new Point(-34, 424);
            zemin.Name = "zemin";
            zemin.Size = new Size(780, 294);
            zemin.SizeMode = PictureBoxSizeMode.CenterImage;
            zemin.TabIndex = 3;
            zemin.TabStop = false;
            // 
            // skor
            // 
            skor.AutoSize = true;
            skor.BackColor = SystemColors.ButtonFace;
            skor.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            skor.Location = new Point(12, 487);
            skor.Name = "skor";
            skor.Size = new Size(110, 38);
            skor.TabIndex = 4;
            skor.Text = "Skor: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // ustsınır
            // 
            ustsınır.Image = (Image)resources.GetObject("ustsınır.Image");
            ustsınır.Location = new Point(-119, -48);
            ustsınır.Name = "ustsınır";
            ustsınır.Size = new Size(891, 62);
            ustsınır.SizeMode = PictureBoxSizeMode.CenterImage;
            ustsınır.TabIndex = 5;
            ustsınır.TabStop = false;
            ustsınır.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(735, 534);
            Controls.Add(boruUst);
            Controls.Add(ustsınır);
            Controls.Add(skor);
            Controls.Add(boruAlt);
            Controls.Add(zemin);
            Controls.Add(hamsi);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flappy Hamsi";
            KeyDown += gameKeyisDown;
            KeyUp += gameKeyisUP;
            ((System.ComponentModel.ISupportInitialize)hamsi).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruUst).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)ustsınır).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox hamsi;
        private PictureBox boruUst;
        private PictureBox boruAlt;
        private PictureBox zemin;
        private Label skor;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox ustsınır;
    }
}
