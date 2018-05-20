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
    public partial class GameScreen : UserControl
    {
        string[] row1 = {"Bulbasaur","Ivysaur","Venusaur","Charmander","Charmeleon","Charizard","Squirtle","Wartortle",
            "Blastoise","Caterpie","Metapod","Butterfree","Weedle","Kakuna","Beedrill","Pidgey","Pidgeotto","Pidgeot",
            "Rattata","Raticate","Spearow","Fearow","Ekans","Arbok","Pikachu","Raichu","Sandshrew","Sandslash","Nidoran♀",
            "Nidorina","Nidoqueen"};
        string[] row2 = {"Nidoran♂","Nidorino","Nidoking","Clefairy","Clefable","Vulpix","Ninetales","Jigglypuff","Wigglytuff",
            "Zubat","Golbat","Oddish","Gloom","Vileplume","Paras","Parasect","Venonat","Venomoth","Diglett","Dugtrio","Meowth",
            "Persian","Psyduck","Golduck","Mankey","Primeape","Growlithe","Arcanine","Poliwag","Poliwhirl","Poliwrath"};
        string[] row3 = {"Abra","Kadabra","Alakazam","Machop","Machoke","Machamp","Bellsprout","Weepinbell","Victreebel",
            "Tentacool","Tentacruel","Geodude","Graveler","Golem","Ponyta","Rapidash","Slowpoke","Slowbro","Magnemite",
            "Magneton","Farfetch'd","Doduo","Dodrio","Seel","Dewgong","Grimer","Muk","Shellder","Cloyster","Gastly","Haunter"};
        string[] row4 = {"Gengar","Onix","Drowzee","Hypno","Krabby","Kingler","Voltorb","Electrode","Exeggcute","Exeggutor",
            "Cubone","Marowak","Hitmonlee","Hitmonchan","Lickitung","Koffing","Weezing","Rhyhorn","Rhydon","Chansey","Tangela",
            "Kangaskhan","Horsea","Seadra","Goldeen","Seaking","Staryu","Starmie","Mr. Mime","Scyther","Jynx"};
        string[] row5 = {"Electabuzz","Magmar","Pinsir","Tauros","Magikarp","Gyarados","Lapras","Ditto","Eevee","Vaporeon",
            "Jolteon","Flareon","Porygon","Omanyte","Omastar","Kabuto","Kabutops","Aerodactyl","Snorlax","Articuno","Zapdos",
            "Moltres","Dratini","Dragonair","Dragonite","Mewtwo","Mew"};

        //SoundPlayer musicPlayer = new SoundPlayer(Properties.Resources.Pokemon_Fire_Red_Music___Professor_Oaks_Lab);
        //TODO: In hard mode, excetion pokemon can be typed at any time which and changes the row that is selected.

        public static int secTime = 0, minTime = 12, TotalSecTime, TotalMinTime;
        int counter, index, lineProgress = 0;

        const double TIMERATE = 2 / 3.75;
        const double PROGRESSRATE = 2.56;
        double timeColour = 0, progressColour = 0;

        public static double progress = 0;

        string easyType, selectRow;
        string[] playLines1, playLines2, playLines3, playLines4, playLines5;
        string[] missedPokemon1, missedPokemon2, missedPokemon3, missedPokemon4, missedPokemon5;

        bool colourup = true, colourdown, colourU = true, colourD, exception, openRows = true;

        public GameScreen()
        {
            InitializeComponent();
            for (int i = 0; i < row1.Count(); i++)
            {
                if (StartScreen.easy == false)
                {
                    rowBoxOne.Text += "" + Environment.NewLine;
                    rowBoxTwo.Text += "" + Environment.NewLine;
                    rowBoxThree.Text += "" + Environment.NewLine;
                    rowBoxFour.Text += "" + Environment.NewLine;
                    rowBoxFive.Text += "" + Environment.NewLine;
                }
                else
                {
                    rowBoxOne.Text += row1[i].First().ToString() + Environment.NewLine;
                    rowBoxTwo.Text += row2[i].First().ToString() + Environment.NewLine;
                    rowBoxThree.Text += row3[i].First().ToString() + Environment.NewLine;
                    rowBoxFour.Text += row4[i].First().ToString() + Environment.NewLine;
                    if (i + 125 <= 151) { rowBoxFive.Text += row5[i].First().ToString() + Environment.NewLine; }
                }
                dexBox1.Items.Add((i + 1).ToString("000"));
                dexBox2.Items.Add((i + 33).ToString("000"));
                dexBox3.Items.Add((i + 63).ToString("000"));
                dexBox4.Items.Add((i + 94).ToString("000"));
                if (i + 125 <= 151) { dexBox5.Items.Add((i + 125).ToString("000")); };
            }

            missedPokemon1 = (string[])row1.Clone();
            missedPokemon2 = (string[])row2.Clone();
            missedPokemon3 = (string[])row3.Clone();
            missedPokemon4 = (string[])row4.Clone();
            missedPokemon5 = (string[])row5.Clone();

            progressLabel.ForeColor = Color.FromArgb(192, 0, 0);
            //musicPlayer.PlayLooping();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush backMenu = new SolidBrush(Color.SteelBlue);
            int xDif = (secTimeLabel.Location.X + secTimeLabel.Width + 10) - (inputBox.Location.X - 10);
            e.Graphics.FillRectangle(backMenu, inputBox.Location.X - 10, inputBox.Location.Y - 2, xDif, inputBox.Height + 4);

            int topLeftOneX = rowBoxOne.Location.X - 1;
            int topLeftOneY = rowBoxOne.Location.Y - 1;

            int boardWidthOne = rowBoxOne.Width + 1;
            int boardHeightOne = rowBoxOne.Height + 1;

            int topLeftTwoX = rowBoxTwo.Location.X - 1;
            int topLeftTwoY = rowBoxTwo.Location.Y - 1;

            int topLeftThreeX = rowBoxThree.Location.X - 1;
            int topLeftThreeY = rowBoxThree.Location.Y - 1;

            int topLeftFourX = rowBoxFour.Location.X - 1;
            int topLeftFourY = rowBoxFour.Location.Y - 1;

            int topLeftFiveX = rowBoxFive.Location.X - 1;
            int topLeftFiveY = rowBoxFive.Location.Y - 1;

            Rectangle boarder1 = new Rectangle(topLeftOneX, topLeftOneY, boardWidthOne, boardHeightOne);
            Rectangle boarder2 = new Rectangle(topLeftTwoX, topLeftTwoY, boardWidthOne, boardHeightOne);
            Rectangle boarder3 = new Rectangle(topLeftThreeX, topLeftThreeY, boardWidthOne, boardHeightOne);
            Rectangle boarder4 = new Rectangle(topLeftFourX, topLeftFourY, boardWidthOne, boardHeightOne);
            Rectangle boarder5 = new Rectangle(topLeftFiveX, topLeftFiveY, boardWidthOne, boardHeightOne);

            e.Graphics.DrawRectangle(Pens.Gray, boarder1);
            e.Graphics.DrawRectangle(Pens.Gray, boarder2);
            e.Graphics.DrawRectangle(Pens.Gray, boarder3);
            e.Graphics.DrawRectangle(Pens.Gray, boarder4);
            e.Graphics.DrawRectangle(Pens.Gray, boarder5);
        }

        public void ExceptionCheck()
        {
            if (inputBox.Text == "Nidoran" || inputBox.Text == "nidoran" && playLines2[0] != row2[0] && playLines1[28] != row1[28])//nidoran exeption
            {
                playLines2[0] = row2[0];
                rowBoxTwo.Lines = playLines2;
                missedPokemon2[0] = "";

                playLines1[28] = row1[28];
                rowBoxOne.Lines = playLines1;
                missedPokemon1[28] = "";

                inputBox.Text = "";
                progress += 2;////work out line progress
                gameProgressBar.Value += 2;
                lineProgress++;
                if (progress == 0) { }
                else { openRows = false; }
                progressLabel.Text = progress.ToString() + " / 151";
                ScoreColourChange();
                exception = true;
            }
            if (inputBox.Text == row1[17] || inputBox.Text == row1[17].ToLower() && playLines1[counter] != row1[counter]) //pidgeotto/pidgeot exception 
            {
                playLines1[17] = row1[17];
                rowBoxOne.Lines = playLines1;
                missedPokemon1[17] = "";
                inputBox.Text = "";
                selectRow = "R1";
                openRows = false;
                progress++;
                gameProgressBar.Value++;
                lineProgress++;
                progressLabel.Text = progress.ToString() + " / 151";
                row1[17] = "not pidgeot";
                ScoreColourChange();
                exception = true;
            }
            if (inputBox.Text == "mr.mime" && playLines4[28] != row4[28])//mr.mime exeption
            {
                playLines4[28] = row4[28];
                rowBoxFour.Lines = playLines4;
                missedPokemon4[28] = "";
                inputBox.Text = "";
                progress++;
                gameProgressBar.Value++;
                selectRow = "R4";
                openRows = false;
                lineProgress++;
                progressLabel.Text = progress.ToString() + " / 151";
                ScoreColourChange();
                exception = true;
            }
            if (inputBox.Text == row5[26] || inputBox.Text == row5[26].ToLower() && playLines5[26] != row5[26]) //mew/mewtwo exception 
            {
                playLines5[26] = row5[26];
                rowBoxFive.Lines = playLines5;
                missedPokemon5[26] = "";
                inputBox.Text = "";
                selectRow = "R5";
                openRows = false;
                progress++;
                gameProgressBar.Value++;
                lineProgress++;
                progressLabel.Text = progress.ToString() + " / 151";
                row5[26] = "not mew";
                ScoreColourChange();
                exception = true;
            }
            if (inputBox.Text == row5[15] || inputBox.Text == row5[15].ToLower() && playLines5[15] != row5[15]) //kabuto/kabutops exception 
            {
                playLines5[15] = row5[15];
                rowBoxFive.Lines = playLines5;
                missedPokemon5[15] = "";
                inputBox.Text = "";
                selectRow = "R5";
                openRows = false;
                progress++;
                gameProgressBar.Value++;
                lineProgress++;
                progressLabel.Text = progress.ToString() + " / 151";
                row5[15] = "not kabuto";
                ScoreColourChange();
                exception = true;
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            counter = 0;
            if (gameTimer.Enabled == false)
            {
                gameTimer.Enabled = true;
            }
            playLines1 = rowBoxOne.Lines;
            playLines2 = rowBoxTwo.Lines;
            playLines3 = rowBoxThree.Lines;
            playLines4 = rowBoxFour.Lines;
            playLines5 = rowBoxFive.Lines;

            #region Row1
            if (selectRow == "R1" && StartScreen.difficult == true || openRows == true && StartScreen.difficult == true || StartScreen.difficult == false)
            {
                foreach (string pokemon in row1)
                {
                    exception = false;
                    easyType = row1[counter].ToLower();

                    ExceptionCheck();

                    if (inputBox.Text == row1[counter] || inputBox.Text == easyType && playLines1[counter] != row1[counter] && exception == false)
                    {
                        playLines1[counter] = row1[counter];
                        rowBoxOne.Lines = playLines1;
                        missedPokemon1[counter] = "";
                        inputBox.Text = "";
                        selectRow = "R1";
                        openRows = false;
                        progress++;
                        gameProgressBar.Value++;
                        lineProgress++;
                        progressLabel.Text = progress.ToString() + " / 151";
                        ScoreColourChange();
                    }
                    counter++;
                }
            }
            #endregion

            #region Row2
            if (selectRow == "R2" && StartScreen.difficult == true || openRows == true && StartScreen.difficult == true || StartScreen.difficult == false)
            {
                Reset();
                foreach (string pokemon in row2)
                {
                    easyType = row2[counter].ToLower();
                    exception = false;

                    ExceptionCheck();

                    if (inputBox.Text == row2[counter] || inputBox.Text == easyType && playLines2[counter] != row2[counter] && exception == false)
                    {
                        playLines2[counter] = row2[counter];
                        rowBoxTwo.Lines = playLines2;
                        missedPokemon2[counter] = "";
                        inputBox.Text = "";
                        selectRow = "R2";
                        openRows = false;
                        progress++;
                        gameProgressBar.Value++;
                        lineProgress++;
                        progressLabel.Text = progress.ToString() + " / 151";
                        ScoreColourChange();
                    }
                    counter++;
                }
            }
            #endregion

            #region Row3
            if (selectRow == "R3" && StartScreen.difficult == true || openRows == true && StartScreen.difficult == true || StartScreen.difficult == false)
            {
                Reset();
                foreach (string pokemon in row3)
                {
                    easyType = row3[counter].ToLower();
                    if (inputBox.Text == row3[counter] || inputBox.Text == easyType && playLines3[counter] != row3[counter])
                    {
                        playLines3[counter] = row3[counter];
                        rowBoxThree.Lines = playLines3;
                        missedPokemon3[counter] = "";
                        inputBox.Text = "";
                        selectRow = "R3";
                        openRows = false;
                        progress++;
                        gameProgressBar.Value++;
                        lineProgress++;
                        progressLabel.Text = progress.ToString() + " / 151";
                        ScoreColourChange();
                    }
                    counter++;
                }
            }
            #endregion

            #region Row4
            if (selectRow == "R4" && StartScreen.difficult == true || openRows == true && StartScreen.difficult == true || StartScreen.difficult == false)
            {
                Reset();
                foreach (string pokemon in row4)
                {
                    easyType = row4[counter].ToLower();
                    exception = false;
                    ExceptionCheck();

                    if (inputBox.Text == row4[counter] || inputBox.Text == easyType && playLines4[counter] != row4[counter] && exception == false)
                    {
                        playLines4[counter] = row4[counter];
                        rowBoxFour.Lines = playLines4;
                        missedPokemon4[counter] = "";
                        inputBox.Text = "";
                        selectRow = "R4";
                        openRows = false;
                        progress++;
                        gameProgressBar.Value++;
                        lineProgress++;
                        progressLabel.Text = progress.ToString() + " / 151";
                        ScoreColourChange();
                    }
                    counter++;
                }
            }
            #endregion

            #region Row5
            if (selectRow == "R5" && StartScreen.difficult == true || openRows == true && StartScreen.difficult == true || StartScreen.difficult == false)
            {

                Reset();
                foreach (string pokemon in row5)
                {
                    easyType = row5[counter].ToLower();
                    exception = false;

                    ExceptionCheck();

                    if (inputBox.Text == row5[counter] || inputBox.Text == easyType && playLines5[counter] != row5[counter] && exception == false)
                    {
                        playLines5[counter] = row5[counter];
                        rowBoxFive.Lines = playLines5;
                        missedPokemon5[counter] = "";
                        inputBox.Text = "";
                        selectRow = "R5";
                        openRows = false;
                        progress++;
                        gameProgressBar.Value++;
                        lineProgress++;
                        progressLabel.Text = progress.ToString() + " / 151";
                        ScoreColourChange();
                    }
                    counter++;
                }
            }
            #endregion

            Reset();//very important refresh, keeps counter in range
            if (progress == 151)
            {
                gameTimer.Stop();
                //musicPlayer.Stop();

                Form f = this.FindForm();
                f.Controls.Remove(this);

                EndScreen es = new EndScreen();
                f.Controls.Add(es);
            }

            if (StartScreen.difficult == true)
            {
                if (lineProgress == 31 || selectRow == "R5" && lineProgress == 27)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        if (selectRow == "R" + i.ToString())
                        {
                            selectRow = "";
                            openRows = true;
                            lineProgress = 0;

                            switch (i)
                            {
                                case 1:
                                    rowBoxOne.BackColor = Color.LimeGreen;
                                    break;
                                case 2:
                                    rowBoxTwo.BackColor = Color.LimeGreen;
                                    break;
                                case 3:
                                    rowBoxThree.BackColor = Color.LimeGreen;
                                    break;
                                case 4:
                                    rowBoxFour.BackColor = Color.LimeGreen;
                                    break;
                                case 5:
                                    rowBoxFive.BackColor = Color.LimeGreen;
                                    break;
                            }
                        }
                    }
                }
            }
        }

        public void ScoreColourChange()
        {
            progressColour = progressColour + PROGRESSRATE;
            if (colourU)
            {
                int green = Convert.ToInt32(progressColour);
                if (green == 192)
                {
                    progressColour = 0;
                    colourD = true;
                    colourU = false;
                }
                else
                {
                    progressLabel.ForeColor = Color.FromArgb(192, green, 0);
                }
            }
            else if (colourD)
            {
                int red = 192 - Convert.ToInt32(progressColour);
                progressLabel.ForeColor = Color.FromArgb(red, 192, 0);
            }

        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (colourup)
            {
                timeColour = timeColour + TIMERATE;
                int red = Convert.ToInt32(timeColour);
                secTimeLabel.ForeColor = Color.FromArgb(red, 192, 0);
                minTimeLabel.ForeColor = secTimeLabel.ForeColor;
                if (red == 192)
                {
                    colourup = false;
                    colourdown = true;
                    timeColour = 0;
                }
            }
            else if (colourdown)
            {
                timeColour = timeColour + TIMERATE;
                int green = Convert.ToInt32(192 - timeColour);
                secTimeLabel.ForeColor = Color.FromArgb(192, green, 0);
                minTimeLabel.ForeColor = secTimeLabel.ForeColor;
            }

            TotalSecTime++;
            if (TotalSecTime == 60)
            {
                TotalMinTime++;
                TotalSecTime = 0;
            }

            if (secTime == 0)
            {
                secTime = 59;
            }
            else
            {
                secTime--;
            }

            if (secTime == 59)
            {
                minTime--;
            }

            secTimeLabel.Text = secTime.ToString("00");
            minTimeLabel.Text = minTime.ToString() + " :";

            if (minTime == 0 && secTime == 0)
            {
                gameTimer.Stop();
                inputBox.Enabled = false;
                //musicPlayer.Stop();
                MissedPokemon();
                showScoreButton.Visible = true;
            }
        }
        public void MissedPokemon()
        {
            Reset();
            missedPokemon1.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            #region Row 1
            foreach (string pokemon in row1)//put in missing pokemon
            {
                if (rowBoxOne.Lines[counter] == row1[counter])
                { }
                else
                {
                    changeLine(rowBoxOne, counter, missedPokemon1[counter]);
                }
                counter++;
            }
            Reset();
            foreach (string pokemon in row1)//colour missing pokemon red
            {
                if (rowBoxOne.Lines[counter] == missedPokemon1[counter])
                {
                    if (counter == 17) // Pidgeot exception
                    { index = rowBoxOne.Text.IndexOf(missedPokemon1[16]) + missedPokemon1[16].Length + 1; }
                    else
                    { index = rowBoxOne.Text.IndexOf(missedPokemon1[counter]); }
                    int length = missedPokemon1[counter].Length;
                    rowBoxOne.Select(index, length);
                    rowBoxOne.SelectionColor = Color.Red;
                }
                counter++;
            }
            #endregion

            #region Row 2
            Reset();
            foreach (string pokemon in row2)
            {
                if (rowBoxTwo.Lines[counter] == row2[counter])
                { }
                else
                {
                    changeLine(rowBoxTwo, counter, missedPokemon2[counter]);
                }
                counter++;
            }
            Reset();
            foreach (string pokemon in row2)
            {
                if (rowBoxTwo.Lines[counter] == missedPokemon2[counter])
                {
                    index = rowBoxTwo.Text.IndexOf(missedPokemon2[counter]);
                    int length = missedPokemon2[counter].Length;
                    rowBoxTwo.Select(index, length);
                    rowBoxTwo.SelectionColor = Color.Red;
                }
                counter++;
            }
            #endregion

            #region Row 3
            Reset();
            foreach (string pokemon in row3)
            {
                if (rowBoxThree.Lines[counter] == row3[counter])
                { }
                else
                {
                    changeLine(rowBoxThree, counter, missedPokemon3[counter]);
                }
                counter++;
            }
            Reset();
            foreach (string pokemon in row3)
            {
                if (rowBoxThree.Lines[counter] == missedPokemon3[counter])
                {
                    index = rowBoxThree.Text.IndexOf(missedPokemon3[counter]);
                    int length = missedPokemon3[counter].Length;
                    rowBoxThree.Select(index, length);
                    rowBoxThree.SelectionColor = Color.Red;
                }
                counter++;
            }
            #endregion

            #region Row 4
            Reset();
            foreach (string pokemon in row4)
            {
                if (rowBoxFour.Lines[counter] == row4[counter])
                { }
                else
                {
                    changeLine(rowBoxFour, counter, missedPokemon4[counter]);
                }
                counter++;
            }
            Reset();
            foreach (string pokemon in row4)
            {
                if (rowBoxFour.Lines[counter] == missedPokemon4[counter])
                {
                    index = rowBoxFour.Text.IndexOf(missedPokemon4[counter]);
                    int length = missedPokemon4[counter].Length;
                    rowBoxFour.Select(index, length);
                    rowBoxFour.SelectionColor = Color.Red;
                }
                counter++;
            }
            #endregion

            #region Row 5
            Reset();
            foreach (string pokemon in row5)
            {
                if (rowBoxFive.Lines[counter] == row5[counter])
                { }
                else
                {
                    changeLine(rowBoxFive, counter, missedPokemon5[counter]);
                }
                counter++;
            }
            Reset();
            foreach (string pokemon in row5)
            {
                if (rowBoxFive.Lines[counter] == missedPokemon5[counter])
                {
                    if (counter == 26) // mew exception
                    {
                        index = rowBoxFive.Text.IndexOf(missedPokemon5[25]) + missedPokemon5[25].Length + 1;
                    }
                    else
                    {
                        index = rowBoxFive.Text.IndexOf(missedPokemon5[counter]);
                    }
                    int length = missedPokemon5[counter].Length;
                    rowBoxFive.Select(index, length);
                    rowBoxFive.SelectionColor = Color.Red;
                }
                counter++;
            }
            #endregion
        }
        public void Reset()
        {
            counter = 0;
        }
        public void changeLine(RichTextBox RTB, int line, string text)
        {
            int s1 = RTB.GetFirstCharIndexFromLine(line);
            int s2 = line < RTB.Lines.Count() - 1 ?
                      RTB.GetFirstCharIndexFromLine(line + 1) - 1 :
                      RTB.Text.Length;
            RTB.Select(s1, s2 - s1);
            RTB.SelectedText = text;
        }
        private void giveUpButton_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            inputBox.Enabled = false;
            //musicPlayer.Stop();
            MissedPokemon();
            showScoreButton.Visible = true;
        }
        private void showScoreButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            EndScreen es = new EndScreen();
            f.Controls.Add(es);
        }
    }
}
