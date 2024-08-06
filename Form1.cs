namespace FlappyHamsi
{
    public partial class Form1 : Form
    {
        int boruhizi = 7;
        int gravity = 12;
        int score = 0;
        bool artý=true;
        public Form1()
        {

            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            
            hamsi.Top += gravity;
            boruUst.Left -= boruhizi;
            boruAlt.Left -= boruhizi;
            skor.Text = "SKORUNUZ: " + score;
            int eski=0;
            if (artý && boruUst.Left < hamsi.Left && boruAlt.Left < hamsi.Left)
            {
                score++;
                artý = false;
            }
            if (boruUst.Left < -150)
            {
                boruUst.Left = 650;
                artý = true;
            }
            if (boruAlt.Left < -180)
            {
                boruAlt.Left = 700;
                artý = true;
            }
            if (hamsi.Bounds.IntersectsWith(boruAlt.Bounds) ||
                hamsi.Bounds.IntersectsWith(boruUst.Bounds) ||
                hamsi.Bounds.IntersectsWith(ustsýnýr.Bounds) ||
                hamsi.Bounds.IntersectsWith(zemin.Bounds))
            {
                endGame();
            }
        }

        private void gameKeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -12;
            }
        }

        private void gameKeyisUP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 12;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            skor.Text = "OYUN BÝTTÝ!!";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
