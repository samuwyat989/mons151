namespace mons151
{
    partial class StartScreen
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
            this.differenceButton = new System.Windows.Forms.Button();
            this.diffModeButton = new System.Windows.Forms.Button();
            this.normalModeButton = new System.Windows.Forms.Button();
            this.easyModeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // differenceButton
            // 
            this.differenceButton.Location = new System.Drawing.Point(111, 346);
            this.differenceButton.Name = "differenceButton";
            this.differenceButton.Size = new System.Drawing.Size(612, 23);
            this.differenceButton.TabIndex = 7;
            this.differenceButton.Text = "Types of Modes";
            this.differenceButton.UseVisualStyleBackColor = true;
            this.differenceButton.Click += new System.EventHandler(this.differenceButton_Click);
            // 
            // diffModeButton
            // 
            this.diffModeButton.Location = new System.Drawing.Point(523, 127);
            this.diffModeButton.Name = "diffModeButton";
            this.diffModeButton.Size = new System.Drawing.Size(200, 200);
            this.diffModeButton.TabIndex = 6;
            this.diffModeButton.Text = "Hard Mode";
            this.diffModeButton.UseVisualStyleBackColor = true;
            this.diffModeButton.Click += new System.EventHandler(this.diffModeButton_Click);
            // 
            // normalModeButton
            // 
            this.normalModeButton.Location = new System.Drawing.Point(317, 127);
            this.normalModeButton.Name = "normalModeButton";
            this.normalModeButton.Size = new System.Drawing.Size(200, 200);
            this.normalModeButton.TabIndex = 5;
            this.normalModeButton.Text = "Normal Mode";
            this.normalModeButton.UseVisualStyleBackColor = true;
            this.normalModeButton.Click += new System.EventHandler(this.normalModeButton_Click);
            // 
            // easyModeButton
            // 
            this.easyModeButton.Location = new System.Drawing.Point(111, 127);
            this.easyModeButton.Name = "easyModeButton";
            this.easyModeButton.Size = new System.Drawing.Size(200, 200);
            this.easyModeButton.TabIndex = 4;
            this.easyModeButton.Text = "Easy Mode";
            this.easyModeButton.UseVisualStyleBackColor = true;
            this.easyModeButton.Click += new System.EventHandler(this.easyModeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(202, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "The Pokemon 151 Challenge";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.differenceButton);
            this.Controls.Add(this.diffModeButton);
            this.Controls.Add(this.normalModeButton);
            this.Controls.Add(this.easyModeButton);
            this.Name = "StartScreen";
            this.Size = new System.Drawing.Size(850, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button differenceButton;
        private System.Windows.Forms.Button diffModeButton;
        private System.Windows.Forms.Button normalModeButton;
        private System.Windows.Forms.Button easyModeButton;
        private System.Windows.Forms.Label label1;
    }
}
