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
            foreach (Player p in Form1.top5Players)
            {
                if (GameScreen.progress > p.score || GameScreen.progress == p.score && gameSeconds < p.mins*60 + p.sec)
                {
                    nameBox.Visible = true;
                    MessageBox.Show("Congradulations, you have made the top 5! Please enter your name in the box below and press enter to claim your score.");
                    break;
                }
            }

         
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

        private void nameBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            string name = nameBox.Text;
            int gameSeconds = GameScreen.TotalMinTime * 60 + GameScreen.TotalSecTime;
            
            if (e.KeyCode == Keys.Enter && name != "")
            {
                for (int i = 0; i < Form1.top5Players.Count; i++)
                {
                    if (GameScreen.progress > Form1.top5Players[i].score || GameScreen.progress == Form1.top5Players[i].score && gameSeconds < Form1.top5Players[i].mins * 60 + Form1.top5Players[i].sec)
                    {                  
                        for (int x = Form1.top5Players.Count- (i+1); x > 0; x--)
                        {
                            Form1.top5Players[i + x] = Form1.top5Players[i + x - 1];
                        }
                        Form1.top5Players[i] = new Player(name, Convert.ToInt32(GameScreen.progress), GameScreen.TotalMinTime, GameScreen.TotalSecTime);
                        break;
                    }
                }

                XmlWriter writer = XmlWriter.Create("Resources/HighScores.xml");

                //Write the root element 
                writer.WriteStartElement("players");

                foreach (Player p in Form1.top5Players)
                {
                    //Start an element 
                    writer.WriteStartElement("player");

                    //Write sub-elements 
                    writer.WriteElementString("name", p.name);
                    writer.WriteElementString("mins", p.mins.ToString());
                    writer.WriteElementString("sec", p.sec.ToString());
                    writer.WriteElementString("score", p.score.ToString());

                    // end the element 
                    writer.WriteEndElement();
                }

                // end the root element 
                writer.WriteEndElement();

                //Write the XML to file and close the writer 
                writer.Close();

                Form f = this.FindForm();
                f.Controls.Remove(this);
                StartScreen ss = new StartScreen();
                f.Controls.Add(ss);
            }
        }
    }
}
