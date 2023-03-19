namespace Clicker_Project
{
    public partial class Form1 : Form
    {
        List<TotalScore> totalScore;
        int Score = 0;
        int Upgrade1Level = 1;
        int Upgrade2Level = 1;
        public Form1()
        {
            InitializeComponent();
            ScoreLabel.Text = Score.ToString();
        }
        public void Remove10score(object sender, EventArgs e)
        {
            Score--;
            Score--;
            Score--;
            Score--;
            Score--;
            Score--;
            Score--;
            Score--;
            Score--;
            Score--;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Upgrade1Level == 1)
            {
                Score++;
                ScoreLabel.Text = Score.ToString();
            }

            if (Upgrade1Level == 2)
            {
                Score++;
                Score++;
                ScoreLabel.Text = Score.ToString();
            }

            if (Upgrade1Level == 3)
            {
                Score++;
                Score++;
                Score++;
                ScoreLabel.Text = Score.ToString();
            }

            if (Upgrade1Level == 4)
            {
                Score++;
                Score++;
                Score++;
                Score++;
                ScoreLabel.Text = Score.ToString();
            }
            
            if (Upgrade1Level == 5)
            {
                Score++;
                Score++;
                Score++;
                Score++;
                Score++;
                ScoreLabel.Text = Score.ToString();
            }

            if (Upgrade1Level == 6)
            {
                Score++;
                Score++;
                Score++;
                Score++;
                Score++;
                Score++;
                Score++;
                Score++;
                Score++;
                Score++;
                ScoreLabel.Text = Score.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Upgrade1Level == 1 && Score >= 15)
            {

                Score--;
                Score--;
                Score--;
                Score--;
                Score--;
                Score--;
                Score--;
                Score--;
                Score--;
                Score--;
                Score--;
                Score--;
                Score--;
                Score--;
                Score--;

                Upgrade1Level++;
                LevelGem.Text = "Level 2";
                UpgradeButton.Text = " Upgrade 1 Level\r\n+3 point pre Click\r\nuse 30 point";
                ScoreLabel.Text = Score.ToString();
            }

            if (Upgrade1Level == 2 && Score >= 30)
            {

                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);

                Upgrade1Level++;
                LevelGem.Text = "Level 3";
                UpgradeButton.Text = " Upgrade 1 Level\r\n+4 point pre Click\r\nuse 60 point";
                ScoreLabel.Text = Score.ToString();
            }

            if (Upgrade1Level == 3 && Score >= 60)
            {

                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);

                Upgrade1Level++;
                LevelGem.Text = "Level 4";
                UpgradeButton.Text = " Upgrade 1 Level\r\n+5 point pre Click\r\nuse 200 point";
                ScoreLabel.Text = Score.ToString();
            }

            if (Upgrade1Level == 4 && Score >= 200)
            {

                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);

                Upgrade1Level++;
                LevelGem.Text = "Level 5";
                UpgradeButton.Text = " Upgrade 1 Level\r\n+10 point pre Click\r\nuse 500 point";
                ScoreLabel.Text = Score.ToString();
            }
            if (Upgrade1Level == 5 && Score >= 500)
            {

                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);

                Upgrade1Level++;
                LevelGem.Text = "Level Max";
                UpgradeButton.Text = "Max Level";
                this.pictureBox1.Image = Properties.Resources.Saint_Quartz_Px;
                ScoreLabel.Text = Score.ToString();
            }
        }

        private void Helper_Click(object sender, EventArgs e)
        {
            if(Upgrade2Level == 1 && Score >= 300) 
            {
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Remove10score(sender, e);
                Upgrade2Level++;
                Helper.Text = "(Currently) Max Level";
                ScoreLabel.Text = Score.ToString();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Score++;
            Score++;
            Score++;
            Score++;
            Score++;
            Score++;
            Score++;
            Score++;
            Score++;
            Score++;
            Score++;
            ScoreLabel.Text = Score.ToString();
        }
    }
}