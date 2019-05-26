namespace WumpusTest
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.pnMainMenu = new System.Windows.Forms.Panel();
            this.lbWumpus = new System.Windows.Forms.Label();
            this.lbThe = new System.Windows.Forms.Label();
            this.lbHunt = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnInstructions = new System.Windows.Forms.Panel();
            this.btnInToMM = new System.Windows.Forms.Button();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.pnNameInput = new System.Windows.Forms.Panel();
            this.btnStToMM = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnGame = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnMainMenu.SuspendLayout();
            this.pnInstructions.SuspendLayout();
            this.pnNameInput.SuspendLayout();
            this.pnGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMainMenu
            // 
            this.pnMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMainMenu.BackgroundImage")));
            this.pnMainMenu.Controls.Add(this.lbWumpus);
            this.pnMainMenu.Controls.Add(this.lbThe);
            this.pnMainMenu.Controls.Add(this.lbHunt);
            this.pnMainMenu.Controls.Add(this.btnTest);
            this.pnMainMenu.Controls.Add(this.btnInstructions);
            this.pnMainMenu.Controls.Add(this.btnHighScores);
            this.pnMainMenu.Controls.Add(this.btnStart);
            this.pnMainMenu.Location = new System.Drawing.Point(-1, 0);
            this.pnMainMenu.Name = "pnMainMenu";
            this.pnMainMenu.Size = new System.Drawing.Size(1463, 946);
            this.pnMainMenu.TabIndex = 0;
            // 
            // lbWumpus
            // 
            this.lbWumpus.AutoSize = true;
            this.lbWumpus.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWumpus.Location = new System.Drawing.Point(106, 585);
            this.lbWumpus.Name = "lbWumpus";
            this.lbWumpus.Size = new System.Drawing.Size(534, 156);
            this.lbWumpus.TabIndex = 7;
            this.lbWumpus.Text = "Wumpus";
            // 
            // lbThe
            // 
            this.lbThe.AutoSize = true;
            this.lbThe.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThe.Location = new System.Drawing.Point(238, 369);
            this.lbThe.Name = "lbThe";
            this.lbThe.Size = new System.Drawing.Size(259, 156);
            this.lbThe.TabIndex = 6;
            this.lbThe.Text = "The";
            // 
            // lbHunt
            // 
            this.lbHunt.AutoSize = true;
            this.lbHunt.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHunt.Location = new System.Drawing.Point(214, 150);
            this.lbHunt.Name = "lbHunt";
            this.lbHunt.Size = new System.Drawing.Size(313, 156);
            this.lbHunt.TabIndex = 5;
            this.lbHunt.Text = "Hunt";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(858, 755);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(295, 99);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(858, 527);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(295, 99);
            this.btnInstructions.TabIndex = 3;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Location = new System.Drawing.Point(858, 293);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(295, 99);
            this.btnHighScores.TabIndex = 2;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(858, 71);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(295, 99);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnInstructions
            // 
            this.pnInstructions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnInstructions.BackgroundImage")));
            this.pnInstructions.Controls.Add(this.btnInToMM);
            this.pnInstructions.Controls.Add(this.rtbInstructions);
            this.pnInstructions.Location = new System.Drawing.Point(-1, 0);
            this.pnInstructions.Name = "pnInstructions";
            this.pnInstructions.Size = new System.Drawing.Size(1466, 946);
            this.pnInstructions.TabIndex = 1;
            // 
            // btnInToMM
            // 
            this.btnInToMM.Location = new System.Drawing.Point(84, 806);
            this.btnInToMM.Name = "btnInToMM";
            this.btnInToMM.Size = new System.Drawing.Size(188, 101);
            this.btnInToMM.TabIndex = 1;
            this.btnInToMM.Text = "Back";
            this.btnInToMM.UseVisualStyleBackColor = true;
            this.btnInToMM.Click += new System.EventHandler(this.btnInToMM_Click);
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Location = new System.Drawing.Point(224, 71);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.ReadOnly = true;
            this.rtbInstructions.Size = new System.Drawing.Size(990, 680);
            this.rtbInstructions.TabIndex = 0;
            this.rtbInstructions.Text = "";
            // 
            // pnNameInput
            // 
            this.pnNameInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnNameInput.BackgroundImage")));
            this.pnNameInput.Controls.Add(this.btnStToMM);
            this.pnNameInput.Controls.Add(this.btnDone);
            this.pnNameInput.Controls.Add(this.label2);
            this.pnNameInput.Controls.Add(this.tbName);
            this.pnNameInput.Controls.Add(this.label1);
            this.pnNameInput.Location = new System.Drawing.Point(-1, 0);
            this.pnNameInput.Name = "pnNameInput";
            this.pnNameInput.Size = new System.Drawing.Size(1463, 946);
            this.pnNameInput.TabIndex = 2;
            // 
            // btnStToMM
            // 
            this.btnStToMM.Location = new System.Drawing.Point(84, 786);
            this.btnStToMM.Name = "btnStToMM";
            this.btnStToMM.Size = new System.Drawing.Size(188, 94);
            this.btnStToMM.TabIndex = 5;
            this.btnStToMM.Text = "Back";
            this.btnStToMM.UseVisualStyleBackColor = true;
            this.btnStToMM.Click += new System.EventHandler(this.btnStToMM_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(621, 560);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(217, 78);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum of 12 characters.\r\nSelect \"Done\" when finished.\r\n";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(480, 467);
            this.tbName.MaxLength = 12;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(500, 57);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // pnGame
            // 
            this.pnGame.Controls.Add(this.pictureBox2);
            this.pnGame.Location = new System.Drawing.Point(-1, 0);
            this.pnGame.Name = "pnGame";
            this.pnGame.Size = new System.Drawing.Size(1466, 800);
            this.pnGame.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(172, 309);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1462, 946);
            this.Controls.Add(this.pnGame);
            this.Controls.Add(this.pnNameInput);
            this.Controls.Add(this.pnMainMenu);
            this.Controls.Add(this.pnInstructions);
            this.Name = "GUI";
            this.pnMainMenu.ResumeLayout(false);
            this.pnMainMenu.PerformLayout();
            this.pnInstructions.ResumeLayout(false);
            this.pnNameInput.ResumeLayout(false);
            this.pnNameInput.PerformLayout();
            this.pnGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMainMenu;
        private System.Windows.Forms.Label lbWumpus;
        private System.Windows.Forms.Label lbThe;
        private System.Windows.Forms.Label lbHunt;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnInstructions;
        private System.Windows.Forms.RichTextBox rtbInstructions;
        private System.Windows.Forms.Panel pnNameInput;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInToMM;
        private System.Windows.Forms.Button btnStToMM;
        private System.Windows.Forms.Panel pnGame;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

