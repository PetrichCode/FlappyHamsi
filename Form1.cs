namespace FlappyHamsi
{
    public partial class Form1 : Form
    {
        int boruhizi = 7;
        int gravity = 12;
        int score = 0;
        bool art�=true;
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
            if (art� && boruUst.Left < hamsi.Left && boruAlt.Left < hamsi.Left)
            {
                score++;
                art� = false;
            }
            if (boruUst.Left < -150)
            {
                boruUst.Left = 650;
                art� = true;
            }
            if (boruAlt.Left < -180)
            {
                boruAlt.Left = 700;
                art� = true;
            }
            if (hamsi.Bounds.IntersectsWith(boruAlt.Bounds) ||
                hamsi.Bounds.IntersectsWith(boruUst.Bounds) ||
                hamsi.Bounds.IntersectsWith(usts�n�r.Bounds) ||
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
            skor.Text = "OYUN B�TT�!!";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
