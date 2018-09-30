namespace NewMinesweeper
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EasyButton = new System.Windows.Forms.RadioButton();
            this.ModerateButton = new System.Windows.Forms.RadioButton();
            this.DifficultButton = new System.Windows.Forms.RadioButton();
            this.PlayButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.PlayButton);
            this.groupBox1.Controls.Add(this.DifficultButton);
            this.groupBox1.Controls.Add(this.ModerateButton);
            this.groupBox1.Controls.Add(this.EasyButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Level";
            // 
            // EasyButton
            // 
            this.EasyButton.AutoSize = true;
            this.EasyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyButton.Location = new System.Drawing.Point(12, 30);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(66, 24);
            this.EasyButton.TabIndex = 0;
            this.EasyButton.TabStop = true;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = true;
            // 
            // ModerateButton
            // 
            this.ModerateButton.AutoSize = true;
            this.ModerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModerateButton.Location = new System.Drawing.Point(12, 65);
            this.ModerateButton.Name = "ModerateButton";
            this.ModerateButton.Size = new System.Drawing.Size(103, 24);
            this.ModerateButton.TabIndex = 1;
            this.ModerateButton.TabStop = true;
            this.ModerateButton.Text = "Moderate";
            this.ModerateButton.UseVisualStyleBackColor = true;
            // 
            // DifficultButton
            // 
            this.DifficultButton.AutoSize = true;
            this.DifficultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultButton.Location = new System.Drawing.Point(12, 100);
            this.DifficultButton.Name = "DifficultButton";
            this.DifficultButton.Size = new System.Drawing.Size(89, 24);
            this.DifficultButton.TabIndex = 2;
            this.DifficultButton.TabStop = true;
            this.DifficultButton.Text = "Difficult";
            this.DifficultButton.UseVisualStyleBackColor = true;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(88, 141);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(117, 34);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Play Button";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(454, 357);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.RadioButton DifficultButton;
        private System.Windows.Forms.RadioButton ModerateButton;
        private System.Windows.Forms.RadioButton EasyButton;
    }
}

