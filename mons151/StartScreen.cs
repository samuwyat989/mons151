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
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        public static Boolean difficult, easy;

        private void normalModeButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }
        private void diffModeButton_Click(object sender, EventArgs e)
        {
            difficult = true;
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }
        private void easyModeButton_Click(object sender, EventArgs e)
        {
            easy = true;
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }
        private void differenceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In 'Easy Mode' you are given the first letter of each pokemon's name.\nIn 'Normal Mode' it is the classic 151 challenge.\nIn 'Hard Mode' you choose which column you want to fill and have to complete it before choosing another.");
        }
    }
}
