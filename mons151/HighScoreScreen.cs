using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace mons151
{
    public partial class HighScoreScreen : UserControl
    {
        public HighScoreScreen()
        {
            InitializeComponent();
        }

        float percentScore = 0, rate = 0;

        private void HighScoreScreen_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void HighScoreScreen_Paint(object sender, PaintEventArgs e)
        {
          
            e.Graphics.DrawString("High Scores", new Font("Roboto", 30), Brushes.Yellow, new Point(50, 50));
            e.Graphics.DrawString("Place", new Font("Roboto", 20), Brushes.Yellow, new Point(55, 90));
            e.Graphics.DrawString("Name", new Font("Roboto", 20), Brushes.Yellow, new Point(155, 90));
            e.Graphics.DrawString("Score", new Font("Roboto", 20), Brushes.Yellow, new Point(255, 90));
            e.Graphics.DrawString("Time", new Font("Roboto", 20), Brushes.Yellow, new Point(355, 90));
            e.Graphics.DrawString("Percent", new Font("Roboto", 20), Brushes.Yellow, new Point(455, 90));
            e.Graphics.DrawString("Rate", new Font("Roboto", 20), Brushes.Yellow, new Point(575, 90));

            int counter = 0, place = 1;
            foreach(Player p in Form1.top5Players)
            {
                FindValues(p.score, p.mins, p.sec);

                if (place == 1)
                {
                    e.Graphics.DrawString("#" + place.ToString() + ": ", new Font("Roboto", 18), Brushes.Goldenrod, new Point(55, 130 + 40 * counter));
                }
                else if(place == 2)
                {
                    e.Graphics.DrawString("#" + place.ToString() + ": ", new Font("Roboto", 18), Brushes.Silver, new Point(55, 130 + 40 * counter));
                }
                else if (place == 3)
                {
                    e.Graphics.DrawString("#" + place.ToString() + ": ", new Font("Roboto", 18), Brushes.RosyBrown, new Point(55, 130 + 40 * counter));
                }
                else
                {
                    e.Graphics.DrawString("#" + place.ToString() + ": ", new Font("Roboto", 18), Brushes.Yellow, new Point(55, 130 + 40 * counter));
                }
                place++;
                e.Graphics.DrawString(p.name, new Font("Roboto", 15), Brushes.Yellow, new Point(155, 130 + 40 * counter));
                e.Graphics.DrawString(p.mins.ToString("00")+ ":" + p.sec.ToString("00"), new Font("Roboto", 15), Brushes.Yellow, new Point(355, 130 + 40 * counter));
                e.Graphics.DrawString(p.score.ToString(), new Font("Roboto", 15), Brushes.Yellow, new Point(255, 130 + 40 * counter));
                e.Graphics.DrawString(rate.ToString("0.00") + " Pokemon/s.", new Font("Roboto", 15), Brushes.Yellow, new Point(575, 130 + 40 * counter));
                e.Graphics.DrawString(percentScore.ToString("0.0") + "%", new Font("Roboto", 15), Brushes.Yellow, new Point(455, 130 + 40 * counter));
                counter++;
            }
        }

        public void FindValues(int score, int min, int sec)
        {
            percentScore = score*100/151F;
            float gameSeconds = min * 60 + sec;
            float scoreF = score;
            rate = scoreF/gameSeconds;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            StartScreen ss = new StartScreen();
            f.Controls.Add(ss);
        }
    }
}
