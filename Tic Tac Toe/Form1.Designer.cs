
namespace Tic_Tac_Toe
{
    partial class TicTacToeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resartToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.PlayersInformationPanel = new System.Windows.Forms.GroupBox();
            this.playerTwoTextBox = new System.Windows.Forms.TextBox();
            this.playerOneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GameSettingPanel = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StartingPlayerTwo = new System.Windows.Forms.RadioButton();
            this.StartingPlayerOne = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.XPlayerTwoRadio = new System.Windows.Forms.RadioButton();
            this.XPlayerOneRadio = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.PlayersInformationPanel.SuspendLayout();
            this.GameSettingPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(221)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.resartToolStripMenuItem,
            this.restartGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.startToolStripMenuItem.Text = " Start game";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // resartToolStripMenuItem
            // 
            this.resartToolStripMenuItem.Name = "resartToolStripMenuItem";
            this.resartToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.restartGameToolStripMenuItem.Text = "Restart game";
            this.restartGameToolStripMenuItem.Click += new System.EventHandler(this.restartGameToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(23, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 112);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(154, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 112);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(285, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 112);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(23, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 112);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(154, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 112);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(285, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 112);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(23, 295);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 112);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(154, 295);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 112);
            this.button8.TabIndex = 1;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(145)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(285, 295);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 112);
            this.button9.TabIndex = 1;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // PlayersInformationPanel
            // 
            this.PlayersInformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(221)))));
            this.PlayersInformationPanel.Controls.Add(this.playerTwoTextBox);
            this.PlayersInformationPanel.Controls.Add(this.playerOneTextBox);
            this.PlayersInformationPanel.Controls.Add(this.label2);
            this.PlayersInformationPanel.Controls.Add(this.label1);
            this.PlayersInformationPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersInformationPanel.Location = new System.Drawing.Point(428, 59);
            this.PlayersInformationPanel.Name = "PlayersInformationPanel";
            this.PlayersInformationPanel.Size = new System.Drawing.Size(331, 151);
            this.PlayersInformationPanel.TabIndex = 2;
            this.PlayersInformationPanel.TabStop = false;
            this.PlayersInformationPanel.Text = "Players Information";
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Location = new System.Drawing.Point(142, 82);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(173, 24);
            this.playerTwoTextBox.TabIndex = 1;
            // 
            // playerOneTextBox
            // 
            this.playerOneTextBox.Location = new System.Drawing.Point(142, 34);
            this.playerOneTextBox.Name = "playerOneTextBox";
            this.playerOneTextBox.Size = new System.Drawing.Size(173, 24);
            this.playerOneTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player Two Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player One Name :";
            // 
            // GameSettingPanel
            // 
            this.GameSettingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(221)))));
            this.GameSettingPanel.Controls.Add(this.groupBox4);
            this.GameSettingPanel.Controls.Add(this.groupBox3);
            this.GameSettingPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameSettingPanel.Location = new System.Drawing.Point(428, 242);
            this.GameSettingPanel.Name = "GameSettingPanel";
            this.GameSettingPanel.Size = new System.Drawing.Size(331, 165);
            this.GameSettingPanel.TabIndex = 2;
            this.GameSettingPanel.TabStop = false;
            this.GameSettingPanel.Text = "Game Settings";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.StartingPlayerTwo);
            this.groupBox4.Controls.Add(this.StartingPlayerOne);
            this.groupBox4.Location = new System.Drawing.Point(10, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 62);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Player\'s Turn";
            // 
            // StartingPlayerTwo
            // 
            this.StartingPlayerTwo.AutoSize = true;
            this.StartingPlayerTwo.Location = new System.Drawing.Point(146, 21);
            this.StartingPlayerTwo.Name = "StartingPlayerTwo";
            this.StartingPlayerTwo.Size = new System.Drawing.Size(103, 22);
            this.StartingPlayerTwo.TabIndex = 0;
            this.StartingPlayerTwo.Text = "Player Two";
            this.StartingPlayerTwo.UseVisualStyleBackColor = true;
            // 
            // StartingPlayerOne
            // 
            this.StartingPlayerOne.AutoSize = true;
            this.StartingPlayerOne.Checked = true;
            this.StartingPlayerOne.Location = new System.Drawing.Point(17, 21);
            this.StartingPlayerOne.Name = "StartingPlayerOne";
            this.StartingPlayerOne.Size = new System.Drawing.Size(102, 22);
            this.StartingPlayerOne.TabIndex = 0;
            this.StartingPlayerOne.TabStop = true;
            this.StartingPlayerOne.Text = "Player One";
            this.StartingPlayerOne.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.XPlayerTwoRadio);
            this.groupBox3.Controls.Add(this.XPlayerOneRadio);
            this.groupBox3.Location = new System.Drawing.Point(10, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 59);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "X For Player";
            // 
            // XPlayerTwoRadio
            // 
            this.XPlayerTwoRadio.AutoSize = true;
            this.XPlayerTwoRadio.Location = new System.Drawing.Point(146, 22);
            this.XPlayerTwoRadio.Name = "XPlayerTwoRadio";
            this.XPlayerTwoRadio.Size = new System.Drawing.Size(103, 22);
            this.XPlayerTwoRadio.TabIndex = 0;
            this.XPlayerTwoRadio.Text = "Player Two";
            this.XPlayerTwoRadio.UseVisualStyleBackColor = true;
            // 
            // XPlayerOneRadio
            // 
            this.XPlayerOneRadio.AutoSize = true;
            this.XPlayerOneRadio.Checked = true;
            this.XPlayerOneRadio.Location = new System.Drawing.Point(17, 22);
            this.XPlayerOneRadio.Name = "XPlayerOneRadio";
            this.XPlayerOneRadio.Size = new System.Drawing.Size(102, 22);
            this.XPlayerOneRadio.TabIndex = 0;
            this.XPlayerOneRadio.TabStop = true;
            this.XPlayerOneRadio.Text = "Player One";
            this.XPlayerOneRadio.UseVisualStyleBackColor = true;
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(149)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(790, 431);
            this.Controls.Add(this.GameSettingPanel);
            this.Controls.Add(this.PlayersInformationPanel);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.TicTacToeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PlayersInformationPanel.ResumeLayout(false);
            this.PlayersInformationPanel.PerformLayout();
            this.GameSettingPanel.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox PlayersInformationPanel;
        private System.Windows.Forms.GroupBox GameSettingPanel;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.TextBox playerOneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton StartingPlayerTwo;
        private System.Windows.Forms.RadioButton StartingPlayerOne;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton XPlayerTwoRadio;
        private System.Windows.Forms.RadioButton XPlayerOneRadio;
        private System.Windows.Forms.ToolStripSeparator resartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
    }
}

