namespace mons151
{
    partial class EndScreen
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
            this.rateLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.congratsLabel = new System.Windows.Forms.Label();
            this.diplomaBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.diplomaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.ForeColor = System.Drawing.Color.Yellow;
            this.rateLabel.Location = new System.Drawing.Point(155, 229);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(567, 39);
            this.rateLabel.TabIndex = 5;
            this.rateLabel.Text = "Your rate of sucess was : 0.17 Pokemon/s.";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(155, 179);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(493, 39);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Your score was : 122/151 or 80.80%.";
            // 
            // congratsLabel
            // 
            this.congratsLabel.AutoSize = true;
            this.congratsLabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.congratsLabel.Location = new System.Drawing.Point(266, 92);
            this.congratsLabel.Name = "congratsLabel";
            this.congratsLabel.Size = new System.Drawing.Size(284, 45);
            this.congratsLabel.TabIndex = 3;
            this.congratsLabel.Text = "Congradulations!";
            // 
            // diplomaBox
            // 
            this.diplomaBox.BackColor = System.Drawing.Color.Yellow;
            this.diplomaBox.BackgroundImage = global::mons151.Properties.Resources.Diploma_RB;
            this.diplomaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.diplomaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diplomaBox.Location = new System.Drawing.Point(311, 282);
            this.diplomaBox.Name = "diplomaBox";
            this.diplomaBox.Size = new System.Drawing.Size(201, 158);
            this.diplomaBox.TabIndex = 6;
            this.diplomaBox.TabStop = false;
            this.diplomaBox.Visible = false;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.diplomaBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.congratsLabel);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(850, 540);
            this.Load += new System.EventHandler(this.EndScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diplomaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label congratsLabel;
        private System.Windows.Forms.PictureBox diplomaBox;
    }
}
