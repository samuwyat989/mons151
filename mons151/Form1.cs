using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace mons151
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Player> top5Players = new List<Player>();

        private void Form1_Load(object sender, EventArgs e)
        {
            GetScores();
            Form f = this.FindForm();
            StartScreen ss = new StartScreen();
            f.Controls.Add(ss);
        }

        public void GetScores()
        {
            XmlReader reader = XmlReader.Create("Resources/HighScores.xml");
            string newName;
            int newScore, newMin, newSec;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newName = reader.ReadContentAsString();

                    reader.ReadToNextSibling("mins");
                    newMin = Convert.ToInt32(reader.ReadElementContentAsString());

                    reader.ReadToNextSibling("sec");
                    newSec = Convert.ToInt32(reader.ReadElementContentAsString());

                    reader.ReadToNextSibling("score");
                    newScore = Convert.ToInt32(reader.ReadElementContentAsString());

                    Player p = new Player(newName, newScore, newMin, newSec);
                    top5Players.Add(p);
                }
            }
        }

    }
}
