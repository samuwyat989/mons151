using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mons151
{
    public partial class EndScreen : UserControl
    {
        public EndScreen()
        {
            InitializeComponent();
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {
            int gameSeconds = GameScreen.TotalMinTime * 60 + GameScreen.TotalSecTime;
            double percentScore;
            percentScore = (GameScreen.progress / 151) * 100;
            double correctRate = GameScreen.progress / gameSeconds;
            if (GameScreen.progress == 151)
            {
                scoreLabel.Text = "Your score was : 151/151 or 100% in "
                   + GameScreen.TotalMinTime.ToString() + ":" + GameScreen.TotalSecTime.ToString("00");
                rateLabel.Text = "Your rate of sucess was : " + correctRate.ToString("0.00") + " Pokemon/s.";
                diplomaBox.Visible = true;
  
            }
            else
            {
                scoreLabel.Text = "Your score was : "+ GameScreen.progress.ToString() + "/151 or " + percentScore.ToString("0.00") + "%.";
                rateLabel.Text = "Your rate of sucess was : " + correctRate.ToString("0.00") + " Pokemon/s.";
            }
        }
    }
}
