namespace mons151
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameProgressBar = new System.Windows.Forms.ProgressBar();
            this.giveUpButton = new System.Windows.Forms.Button();
            this.rowBoxTwo = new System.Windows.Forms.RichTextBox();
            this.rowBoxThree = new System.Windows.Forms.RichTextBox();
            this.rowBoxFour = new System.Windows.Forms.RichTextBox();
            this.rowBoxFive = new System.Windows.Forms.RichTextBox();
            this.showScoreButton = new System.Windows.Forms.Button();
            this.rowBoxOne = new System.Windows.Forms.RichTextBox();
            this.secTimeLabel = new System.Windows.Forms.Label();
            this.minTimeLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.dexBox5 = new System.Windows.Forms.ListBox();
            this.dexBox4 = new System.Windows.Forms.ListBox();
            this.dexBox3 = new System.Windows.Forms.ListBox();
            this.dexBox2 = new System.Windows.Forms.ListBox();
            this.dexBox1 = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameProgressBar
            // 
            this.gameProgressBar.Location = new System.Drawing.Point(363, 20);
            this.gameProgressBar.Maximum = 151;
            this.gameProgressBar.Name = "gameProgressBar";
            this.gameProgressBar.Size = new System.Drawing.Size(196, 33);
            this.gameProgressBar.TabIndex = 52;
            // 
            // giveUpButton
            // 
            this.giveUpButton.Location = new System.Drawing.Point(565, 20);
            this.giveUpButton.Name = "giveUpButton";
            this.giveUpButton.Size = new System.Drawing.Size(100, 33);
            this.giveUpButton.TabIndex = 51;
            this.giveUpButton.Text = "Give Up";
            this.giveUpButton.UseVisualStyleBackColor = true;
            this.giveUpButton.Click += new System.EventHandler(this.giveUpButton_Click);
            // 
            // rowBoxTwo
            // 
            this.rowBoxTwo.BackColor = System.Drawing.Color.White;
            this.rowBoxTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rowBoxTwo.Location = new System.Drawing.Point(220, 71);
            this.rowBoxTwo.Name = "rowBoxTwo";
            this.rowBoxTwo.ReadOnly = true;
            this.rowBoxTwo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rowBoxTwo.Size = new System.Drawing.Size(100, 407);
            this.rowBoxTwo.TabIndex = 50;
            this.rowBoxTwo.Text = "";
            // 
            // rowBoxThree
            // 
            this.rowBoxThree.BackColor = System.Drawing.Color.White;
            this.rowBoxThree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rowBoxThree.Location = new System.Drawing.Point(393, 71);
            this.rowBoxThree.Name = "rowBoxThree";
            this.rowBoxThree.ReadOnly = true;
            this.rowBoxThree.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rowBoxThree.Size = new System.Drawing.Size(100, 407);
            this.rowBoxThree.TabIndex = 49;
            this.rowBoxThree.Text = "";
            // 
            // rowBoxFour
            // 
            this.rowBoxFour.BackColor = System.Drawing.Color.White;
            this.rowBoxFour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rowBoxFour.Location = new System.Drawing.Point(565, 71);
            this.rowBoxFour.Name = "rowBoxFour";
            this.rowBoxFour.ReadOnly = true;
            this.rowBoxFour.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rowBoxFour.Size = new System.Drawing.Size(100, 407);
            this.rowBoxFour.TabIndex = 48;
            this.rowBoxFour.Text = "";
            // 
            // rowBoxFive
            // 
            this.rowBoxFive.BackColor = System.Drawing.Color.White;
            this.rowBoxFive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rowBoxFive.Location = new System.Drawing.Point(737, 71);
            this.rowBoxFive.Name = "rowBoxFive";
            this.rowBoxFive.ReadOnly = true;
            this.rowBoxFive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rowBoxFive.Size = new System.Drawing.Size(100, 407);
            this.rowBoxFive.TabIndex = 47;
            this.rowBoxFive.Text = "";
            // 
            // showScoreButton
            // 
            this.showScoreButton.Location = new System.Drawing.Point(13, 484);
            this.showScoreButton.Name = "showScoreButton";
            this.showScoreButton.Size = new System.Drawing.Size(177, 23);
            this.showScoreButton.TabIndex = 46;
            this.showScoreButton.Text = "Click here to see score";
            this.showScoreButton.UseVisualStyleBackColor = true;
            this.showScoreButton.Visible = false;
            this.showScoreButton.Click += new System.EventHandler(this.showScoreButton_Click);
            // 
            // rowBoxOne
            // 
            this.rowBoxOne.BackColor = System.Drawing.Color.White;
            this.rowBoxOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rowBoxOne.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rowBoxOne.Location = new System.Drawing.Point(49, 71);
            this.rowBoxOne.Name = "rowBoxOne";
            this.rowBoxOne.ReadOnly = true;
            this.rowBoxOne.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rowBoxOne.Size = new System.Drawing.Size(100, 407);
            this.rowBoxOne.TabIndex = 45;
            this.rowBoxOne.Text = "";
            // 
            // secTimeLabel
            // 
            this.secTimeLabel.AutoSize = true;
            this.secTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.secTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.secTimeLabel.Location = new System.Drawing.Point(751, 22);
            this.secTimeLabel.Name = "secTimeLabel";
            this.secTimeLabel.Size = new System.Drawing.Size(46, 31);
            this.secTimeLabel.TabIndex = 44;
            this.secTimeLabel.Text = "00";
            this.secTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minTimeLabel
            // 
            this.minTimeLabel.AutoSize = true;
            this.minTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.minTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.minTimeLabel.Location = new System.Drawing.Point(695, 22);
            this.minTimeLabel.Name = "minTimeLabel";
            this.minTimeLabel.Size = new System.Drawing.Size(63, 31);
            this.minTimeLabel.TabIndex = 43;
            this.minTimeLabel.Text = "12 :";
            this.minTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.ForeColor = System.Drawing.Color.Black;
            this.progressLabel.Location = new System.Drawing.Point(209, 20);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(105, 33);
            this.progressLabel.TabIndex = 42;
            this.progressLabel.Text = "0 / 151";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dexBox5
            // 
            this.dexBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dexBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexBox5.ForeColor = System.Drawing.Color.DimGray;
            this.dexBox5.FormattingEnabled = true;
            this.dexBox5.Location = new System.Drawing.Point(701, 71);
            this.dexBox5.Name = "dexBox5";
            this.dexBox5.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.dexBox5.Size = new System.Drawing.Size(30, 407);
            this.dexBox5.TabIndex = 41;
            // 
            // dexBox4
            // 
            this.dexBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dexBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexBox4.ForeColor = System.Drawing.Color.DimGray;
            this.dexBox4.FormattingEnabled = true;
            this.dexBox4.Location = new System.Drawing.Point(529, 71);
            this.dexBox4.Name = "dexBox4";
            this.dexBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.dexBox4.Size = new System.Drawing.Size(30, 407);
            this.dexBox4.TabIndex = 40;
            // 
            // dexBox3
            // 
            this.dexBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dexBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexBox3.ForeColor = System.Drawing.Color.DimGray;
            this.dexBox3.FormattingEnabled = true;
            this.dexBox3.Location = new System.Drawing.Point(357, 71);
            this.dexBox3.Name = "dexBox3";
            this.dexBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.dexBox3.Size = new System.Drawing.Size(30, 407);
            this.dexBox3.TabIndex = 39;
            // 
            // dexBox2
            // 
            this.dexBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dexBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexBox2.ForeColor = System.Drawing.Color.DimGray;
            this.dexBox2.FormattingEnabled = true;
            this.dexBox2.Location = new System.Drawing.Point(184, 71);
            this.dexBox2.Name = "dexBox2";
            this.dexBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.dexBox2.Size = new System.Drawing.Size(30, 407);
            this.dexBox2.TabIndex = 38;
            // 
            // dexBox1
            // 
            this.dexBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dexBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexBox1.ForeColor = System.Drawing.Color.DimGray;
            this.dexBox1.FormattingEnabled = true;
            this.dexBox1.Location = new System.Drawing.Point(13, 71);
            this.dexBox1.Name = "dexBox1";
            this.dexBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.dexBox1.Size = new System.Drawing.Size(30, 407);
            this.dexBox1.TabIndex = 37;
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(49, 20);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(154, 33);
            this.inputBox.TabIndex = 36;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::mons151.Properties.Resources.Pokemon_Research_Lab_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gameProgressBar);
            this.Controls.Add(this.giveUpButton);
            this.Controls.Add(this.rowBoxTwo);
            this.Controls.Add(this.rowBoxThree);
            this.Controls.Add(this.rowBoxFour);
            this.Controls.Add(this.rowBoxFive);
            this.Controls.Add(this.showScoreButton);
            this.Controls.Add(this.rowBoxOne);
            this.Controls.Add(this.secTimeLabel);
            this.Controls.Add(this.minTimeLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.dexBox5);
            this.Controls.Add(this.dexBox4);
            this.Controls.Add(this.dexBox3);
            this.Controls.Add(this.dexBox2);
            this.Controls.Add(this.dexBox1);
            this.Controls.Add(this.inputBox);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(850, 540);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar gameProgressBar;
        private System.Windows.Forms.Button giveUpButton;
        private System.Windows.Forms.RichTextBox rowBoxTwo;
        private System.Windows.Forms.RichTextBox rowBoxThree;
        private System.Windows.Forms.RichTextBox rowBoxFour;
        private System.Windows.Forms.RichTextBox rowBoxFive;
        private System.Windows.Forms.Button showScoreButton;
        private System.Windows.Forms.RichTextBox rowBoxOne;
        private System.Windows.Forms.Label secTimeLabel;
        private System.Windows.Forms.Label minTimeLabel;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ListBox dexBox5;
        private System.Windows.Forms.ListBox dexBox4;
        private System.Windows.Forms.ListBox dexBox3;
        private System.Windows.Forms.ListBox dexBox2;
        private System.Windows.Forms.ListBox dexBox1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Timer gameTimer;
    }
}
