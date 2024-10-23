namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnRoll = new Button();
            btnReset = new Button();
            groupboxStats = new GroupBox();
            lblTimesGuessedWrongStat = new Label();
            lblTimesGuessedRightStat = new Label();
            lblTimesPlayedStat = new Label();
            lblGuessedWrong = new Label();
            lblGuessedRight = new Label();
            lblTimesPlayed = new Label();
            pictureBox1 = new PictureBox();
            tblDiceInfo = new TableLayoutPanel();
            lblDiceSide = new Label();
            lblDiceFrequency = new Label();
            lblDicePercentage = new Label();
            lblDiceGuesses = new Label();
            lblDiceSide1 = new Label();
            lblDiceSide2 = new Label();
            lblDiceSide3 = new Label();
            lblDiceSide4 = new Label();
            lblDiceSide5 = new Label();
            lblDiceSide6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtbxGuess = new TextBox();
            label19 = new Label();
            groupboxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tblDiceInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(706, 518);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(75, 23);
            btnRoll.TabIndex = 0;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += new System.EventHandler(btnRoll_Click);
            // 
            // btnReset
            // 
            btnReset.AccessibleRole = AccessibleRole.OutlineButton;
            btnReset.Location = new Point(787, 518);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupboxStats
            // 
            groupboxStats.Controls.Add(lblTimesGuessedWrongStat);
            groupboxStats.Controls.Add(lblTimesGuessedRightStat);
            groupboxStats.Controls.Add(lblTimesPlayedStat);
            groupboxStats.Controls.Add(lblGuessedWrong);
            groupboxStats.Controls.Add(lblGuessedRight);
            groupboxStats.Controls.Add(lblTimesPlayed);
            groupboxStats.Location = new Point(469, 64);
            groupboxStats.Name = "groupboxStats";
            groupboxStats.Size = new Size(349, 152);
            groupboxStats.TabIndex = 2;
            groupboxStats.TabStop = false;
            groupboxStats.Text = "Stat Board";
            // 
            // lblTimesGuessedWrongStat
            // 
            lblTimesGuessedWrongStat.AutoSize = true;
            lblTimesGuessedWrongStat.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimesGuessedWrongStat.Location = new Point(306, 93);
            lblTimesGuessedWrongStat.Name = "lblTimesGuessedWrongStat";
            lblTimesGuessedWrongStat.Size = new Size(32, 37);
            lblTimesGuessedWrongStat.TabIndex = 5;
            lblTimesGuessedWrongStat.Text = "0";
            // 
            // lblTimesGuessedRightStat
            // 
            lblTimesGuessedRightStat.AutoSize = true;
            lblTimesGuessedRightStat.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimesGuessedRightStat.Location = new Point(306, 56);
            lblTimesGuessedRightStat.Name = "lblTimesGuessedRightStat";
            lblTimesGuessedRightStat.Size = new Size(32, 37);
            lblTimesGuessedRightStat.TabIndex = 4;
            lblTimesGuessedRightStat.Text = "0";
            // 
            // lblTimesPlayedStat
            // 
            lblTimesPlayedStat.AutoSize = true;
            lblTimesPlayedStat.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimesPlayedStat.Location = new Point(306, 19);
            lblTimesPlayedStat.Name = "lblTimesPlayedStat";
            lblTimesPlayedStat.Size = new Size(32, 37);
            lblTimesPlayedStat.TabIndex = 3;
            lblTimesPlayedStat.Text = "0";
            // 
            // lblGuessedWrong
            // 
            lblGuessedWrong.AutoSize = true;
            lblGuessedWrong.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGuessedWrong.Location = new Point(18, 93);
            lblGuessedWrong.Name = "lblGuessedWrong";
            lblGuessedWrong.Size = new Size(281, 37);
            lblGuessedWrong.TabIndex = 2;
            lblGuessedWrong.Text = "Times Guessed Wrong";
            // 
            // lblGuessedRight
            // 
            lblGuessedRight.AutoSize = true;
            lblGuessedRight.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGuessedRight.Location = new Point(18, 56);
            lblGuessedRight.Name = "lblGuessedRight";
            lblGuessedRight.Size = new Size(263, 37);
            lblGuessedRight.TabIndex = 1;
            lblGuessedRight.Text = "Times Guessed Right";
            // 
            // lblTimesPlayed
            // 
            lblTimesPlayed.AutoSize = true;
            lblTimesPlayed.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimesPlayed.Location = new Point(18, 19);
            lblTimesPlayed.Name = "lblTimesPlayed";
            lblTimesPlayed.Size = new Size(172, 37);
            lblTimesPlayed.TabIndex = 0;
            lblTimesPlayed.Text = "Times Played";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(316, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tblDiceInfo
            // 
            tblDiceInfo.ColumnCount = 4;
            tblDiceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDiceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDiceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDiceInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDiceInfo.Controls.Add(lblDiceSide, 0, 0);
            tblDiceInfo.Controls.Add(lblDiceFrequency, 1, 0);
            tblDiceInfo.Controls.Add(lblDicePercentage, 2, 0);
            tblDiceInfo.Controls.Add(lblDiceGuesses, 3, 0);
            tblDiceInfo.Controls.Add(lblDiceSide1, 0, 1);
            tblDiceInfo.Controls.Add(lblDiceSide2, 0, 2);
            tblDiceInfo.Controls.Add(lblDiceSide3, 0, 3);
            tblDiceInfo.Controls.Add(lblDiceSide4, 0, 4);
            tblDiceInfo.Controls.Add(lblDiceSide5, 0, 5);
            tblDiceInfo.Controls.Add(lblDiceSide6, 0, 6);
            tblDiceInfo.Controls.Add(label1, 1, 1);
            tblDiceInfo.Controls.Add(label2, 1, 2);
            tblDiceInfo.Controls.Add(label3, 1, 3);
            tblDiceInfo.Controls.Add(label4, 1, 4);
            tblDiceInfo.Controls.Add(label5, 1, 5);
            tblDiceInfo.Controls.Add(label6, 1, 6);
            tblDiceInfo.Controls.Add(label7, 2, 1);
            tblDiceInfo.Controls.Add(label8, 2, 2);
            tblDiceInfo.Controls.Add(label9, 2, 3);
            tblDiceInfo.Controls.Add(label10, 2, 4);
            tblDiceInfo.Controls.Add(label11, 2, 5);
            tblDiceInfo.Controls.Add(label12, 2, 6);
            tblDiceInfo.Controls.Add(label13, 3, 1);
            tblDiceInfo.Controls.Add(label14, 3, 2);
            tblDiceInfo.Controls.Add(label15, 3, 3);
            tblDiceInfo.Controls.Add(label16, 3, 4);
            tblDiceInfo.Controls.Add(label17, 3, 5);
            tblDiceInfo.Controls.Add(label18, 3, 6);
            tblDiceInfo.Location = new Point(469, 263);
            tblDiceInfo.Name = "tblDiceInfo";
            tblDiceInfo.RowCount = 7;
            tblDiceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblDiceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblDiceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblDiceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblDiceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblDiceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblDiceInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblDiceInfo.Size = new Size(600, 200);
            tblDiceInfo.TabIndex = 4;
            // 
            // lblDiceSide
            // 
            lblDiceSide.AutoSize = true;
            lblDiceSide.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiceSide.Location = new Point(3, 0);
            lblDiceSide.Name = "lblDiceSide";
            lblDiceSide.Size = new Size(90, 25);
            lblDiceSide.TabIndex = 5;
            lblDiceSide.Text = "Dice Side";
            // 
            // lblDiceFrequency
            // 
            lblDiceFrequency.AutoSize = true;
            lblDiceFrequency.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiceFrequency.Location = new Point(153, 0);
            lblDiceFrequency.Name = "lblDiceFrequency";
            lblDiceFrequency.Size = new Size(99, 25);
            lblDiceFrequency.TabIndex = 6;
            lblDiceFrequency.Text = "Frequency";
            // 
            // lblDicePercentage
            // 
            lblDicePercentage.AutoSize = true;
            lblDicePercentage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDicePercentage.Location = new Point(303, 0);
            lblDicePercentage.Name = "lblDicePercentage";
            lblDicePercentage.Size = new Size(106, 25);
            lblDicePercentage.TabIndex = 7;
            lblDicePercentage.Text = "Percentage";
            // 
            // lblDiceGuesses
            // 
            lblDiceGuesses.AutoSize = true;
            lblDiceGuesses.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiceGuesses.Location = new Point(453, 0);
            lblDiceGuesses.Name = "lblDiceGuesses";
            lblDiceGuesses.Size = new Size(80, 25);
            lblDiceGuesses.TabIndex = 8;
            lblDiceGuesses.Text = "Guesses";
            // 
            // lblDiceSide1
            // 
            lblDiceSide1.AutoSize = true;
            lblDiceSide1.Location = new Point(3, 28);
            lblDiceSide1.Name = "lblDiceSide1";
            lblDiceSide1.Size = new Size(13, 15);
            lblDiceSide1.TabIndex = 9;
            lblDiceSide1.Text = "1";
            // 
            // lblDiceSide2
            // 
            lblDiceSide2.AutoSize = true;
            lblDiceSide2.Location = new Point(3, 56);
            lblDiceSide2.Name = "lblDiceSide2";
            lblDiceSide2.Size = new Size(13, 15);
            lblDiceSide2.TabIndex = 10;
            lblDiceSide2.Text = "2";
            // 
            // lblDiceSide3
            // 
            lblDiceSide3.AutoSize = true;
            lblDiceSide3.Location = new Point(3, 84);
            lblDiceSide3.Name = "lblDiceSide3";
            lblDiceSide3.Size = new Size(13, 15);
            lblDiceSide3.TabIndex = 11;
            lblDiceSide3.Text = "3";
            // 
            // lblDiceSide4
            // 
            lblDiceSide4.AutoSize = true;
            lblDiceSide4.Location = new Point(3, 112);
            lblDiceSide4.Name = "lblDiceSide4";
            lblDiceSide4.Size = new Size(13, 15);
            lblDiceSide4.TabIndex = 12;
            lblDiceSide4.Text = "4";
            // 
            // lblDiceSide5
            // 
            lblDiceSide5.AutoSize = true;
            lblDiceSide5.Location = new Point(3, 140);
            lblDiceSide5.Name = "lblDiceSide5";
            lblDiceSide5.Size = new Size(13, 15);
            lblDiceSide5.TabIndex = 13;
            lblDiceSide5.Text = "5";
            // 
            // lblDiceSide6
            // 
            lblDiceSide6.AutoSize = true;
            lblDiceSide6.Location = new Point(3, 168);
            lblDiceSide6.Name = "lblDiceSide6";
            lblDiceSide6.Size = new Size(13, 15);
            lblDiceSide6.TabIndex = 14;
            lblDiceSide6.Text = "6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 28);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 15;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 56);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 16;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 84);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 17;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 112);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 18;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 140);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 19;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 168);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 20;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 28);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 21;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 56);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 22;
            label8.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(303, 84);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 23;
            label9.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(303, 112);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 24;
            label10.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(303, 140);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 25;
            label11.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(303, 168);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 26;
            label12.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(453, 28);
            label13.Name = "label13";
            label13.Size = new Size(13, 15);
            label13.TabIndex = 27;
            label13.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(453, 56);
            label14.Name = "label14";
            label14.Size = new Size(13, 15);
            label14.TabIndex = 28;
            label14.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(453, 84);
            label15.Name = "label15";
            label15.Size = new Size(13, 15);
            label15.TabIndex = 29;
            label15.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(453, 112);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 30;
            label16.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(453, 140);
            label17.Name = "label17";
            label17.Size = new Size(13, 15);
            label17.TabIndex = 31;
            label17.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(453, 168);
            label18.Name = "label18";
            label18.Size = new Size(13, 15);
            label18.TabIndex = 32;
            label18.Text = "0";
            // 
            // txtbxGuess
            // 
            txtbxGuess.Location = new Point(600, 518);
            txtbxGuess.MaxLength = 1;
            txtbxGuess.Name = "txtbxGuess";
            txtbxGuess.Size = new Size(100, 23);
            txtbxGuess.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(469, 522);
            label19.Name = "label19";
            label19.Size = new Size(125, 15);
            label19.TabIndex = 6;
            label19.Text = "Enter your guess (1-6):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(label19);
            Controls.Add(txtbxGuess);
            Controls.Add(tblDiceInfo);
            Controls.Add(pictureBox1);
            Controls.Add(groupboxStats);
            Controls.Add(btnReset);
            Controls.Add(btnRoll);
            Name = "Form1";
            Text = "Form1";
            groupboxStats.ResumeLayout(false);
            groupboxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tblDiceInfo.ResumeLayout(false);
            tblDiceInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRoll;
        private Button btnReset;
        private GroupBox groupboxStats;
        private Label lblGuessedRight;
        private Label lblTimesPlayed;
        private Label lblGuessedWrong;
        private Label lblTimesGuessedWrongStat;
        private Label lblTimesGuessedRightStat;
        private Label lblTimesPlayedStat;
        private PictureBox pictureBox1;
        private TableLayoutPanel tblDiceInfo;
        private Label lblDiceSide;
        private Label lblDiceFrequency;
        private Label lblDicePercentage;
        private Label lblDiceGuesses;
        private Label lblDiceSide1;
        private Label lblDiceSide2;
        private Label lblDiceSide3;
        private Label lblDiceSide4;
        private Label lblDiceSide5;
        private Label lblDiceSide6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox txtbxGuess;
        private Label label19;
    }
}
