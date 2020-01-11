namespace ShapeHunt
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioDifficulty1 = new System.Windows.Forms.RadioButton();
            this.radioDifficulty2 = new System.Windows.Forms.RadioButton();
            this.radioDifficulty3 = new System.Windows.Forms.RadioButton();
            this.difficultyText = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.scoreButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            this.MoveWorker = new System.ComponentModel.BackgroundWorker();
            this.DrawWorker = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioDifficulty1
            // 
            this.radioDifficulty1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioDifficulty1.AutoSize = true;
            this.radioDifficulty1.Checked = true;
            this.radioDifficulty1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioDifficulty1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioDifficulty1.Location = new System.Drawing.Point(575, 174);
            this.radioDifficulty1.Name = "radioDifficulty1";
            this.radioDifficulty1.Size = new System.Drawing.Size(110, 42);
            this.radioDifficulty1.TabIndex = 0;
            this.radioDifficulty1.TabStop = true;
            this.radioDifficulty1.Tag = "1";
            this.radioDifficulty1.Text = "Łatwy";
            this.radioDifficulty1.UseVisualStyleBackColor = true;
            this.radioDifficulty1.CheckedChanged += new System.EventHandler(this.Difficulty1_Checked);
            // 
            // radioDifficulty2
            // 
            this.radioDifficulty2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioDifficulty2.AutoSize = true;
            this.radioDifficulty2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioDifficulty2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioDifficulty2.Location = new System.Drawing.Point(575, 214);
            this.radioDifficulty2.Name = "radioDifficulty2";
            this.radioDifficulty2.Size = new System.Drawing.Size(119, 42);
            this.radioDifficulty2.TabIndex = 1;
            this.radioDifficulty2.TabStop = true;
            this.radioDifficulty2.Tag = "2";
            this.radioDifficulty2.Text = "Średni";
            this.radioDifficulty2.UseVisualStyleBackColor = true;
            this.radioDifficulty2.CheckedChanged += new System.EventHandler(this.Difficulty2_Checked);
            // 
            // radioDifficulty3
            // 
            this.radioDifficulty3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioDifficulty3.AutoSize = true;
            this.radioDifficulty3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioDifficulty3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioDifficulty3.Location = new System.Drawing.Point(575, 254);
            this.radioDifficulty3.Name = "radioDifficulty3";
            this.radioDifficulty3.Size = new System.Drawing.Size(124, 42);
            this.radioDifficulty3.TabIndex = 2;
            this.radioDifficulty3.TabStop = true;
            this.radioDifficulty3.Tag = "3";
            this.radioDifficulty3.Text = "Trudny";
            this.radioDifficulty3.UseVisualStyleBackColor = true;
            this.radioDifficulty3.CheckedChanged += new System.EventHandler(this.Difficulty3_Checked);
            // 
            // difficultyText
            // 
            this.difficultyText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.difficultyText.AutoSize = true;
            this.difficultyText.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficultyText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.difficultyText.Location = new System.Drawing.Point(512, 131);
            this.difficultyText.Name = "difficultyText";
            this.difficultyText.Size = new System.Drawing.Size(245, 40);
            this.difficultyText.TabIndex = 3;
            this.difficultyText.Text = "Poziom trudności";
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.ForeColor = System.Drawing.Color.DarkOrange;
            this.Title.Location = new System.Drawing.Point(450, 0);
            this.Title.Name = "Title";
            this.Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Title.Size = new System.Drawing.Size(367, 90);
            this.Title.TabIndex = 4;
            this.Title.Text = "ShapeHunt";
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playButton.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playButton.Location = new System.Drawing.Point(352, 316);
            this.playButton.MaximumSize = new System.Drawing.Size(576, 50);
            this.playButton.MinimumSize = new System.Drawing.Size(576, 50);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(576, 50);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Graj";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.Menu_Load);
            // 
            // scoreButton
            // 
            this.scoreButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scoreButton.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scoreButton.Location = new System.Drawing.Point(352, 372);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(576, 50);
            this.scoreButton.TabIndex = 6;
            this.scoreButton.Text = "Wyniki";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.scoreButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.difficultyText);
            this.panel1.Controls.Add(this.radioDifficulty3);
            this.panel1.Controls.Add(this.radioDifficulty2);
            this.panel1.Controls.Add(this.radioDifficulty1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 540);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.MenuButton);
            this.panel2.Location = new System.Drawing.Point(0, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 205);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(298, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 38);
            this.label7.TabIndex = 6;
            this.label7.Text = "Czas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(298, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pudła:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(56, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trafienia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(56, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poziom: łatwy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(393, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(207, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(393, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuButton.Location = new System.Drawing.Point(1045, 42);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(185, 122);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.BackToMenu);
            // 
            // MoveWorker
            // 
            this.MoveWorker.WorkerSupportsCancellation = true;
            this.MoveWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MoveWorker_DoWork);
            // 
            // DrawWorker
            // 
            this.DrawWorker.WorkerSupportsCancellation = true;
            this.DrawWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DrawWorker_DoWork);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(657, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 38);
            this.label8.TabIndex = 7;
            this.label8.Text = "Szukany kształt";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Location = new System.Drawing.Point(717, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 8;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 742);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 780);
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "ShapeHunt";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label difficultyText;
        private System.Windows.Forms.RadioButton radioDifficulty3;
        private System.Windows.Forms.RadioButton radioDifficulty2;
        private System.Windows.Forms.RadioButton radioDifficulty1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MenuButton;
        private System.ComponentModel.BackgroundWorker MoveWorker;
        private System.ComponentModel.BackgroundWorker DrawWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
    }
}

