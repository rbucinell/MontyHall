namespace MontyHall
{
    partial class MontyHallSim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.percentWonLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.displayPercent = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GameMessage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.recentGamesListView = new System.Windows.Forms.ListView();
            this.Game = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pick = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Show = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Decide = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.simulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulateManyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.door3 = new System.Windows.Forms.Button();
            this.door2 = new System.Windows.Forms.Button();
            this.door1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.percentWonLabel,
            this.displayPercent});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(529, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // percentWonLabel
            // 
            this.percentWonLabel.Name = "percentWonLabel";
            this.percentWonLabel.Size = new System.Drawing.Size(74, 21);
            this.percentWonLabel.Text = "Games Won:";
            // 
            // displayPercent
            // 
            this.displayPercent.Name = "displayPercent";
            this.displayPercent.Size = new System.Drawing.Size(420, 20);
            this.displayPercent.Step = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.simulateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNameToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newNameToolStripMenuItem
            // 
            this.newNameToolStripMenuItem.Name = "newNameToolStripMenuItem";
            this.newNameToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newNameToolStripMenuItem.Text = "New Game";
            this.newNameToolStripMenuItem.Click += new System.EventHandler(this.newNameToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exportToolStripMenuItem.Text = "Export History";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.GameMessage);
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // GameMessage
            // 
            this.GameMessage.AutoSize = true;
            this.GameMessage.Location = new System.Drawing.Point(11, 23);
            this.GameMessage.Name = "GameMessage";
            this.GameMessage.Size = new System.Drawing.Size(306, 13);
            this.GameMessage.TabIndex = 0;
            this.GameMessage.Text = "Lets make a deal! Pick a door where you think the sports car is!";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.recentGamesListView);
            this.groupBox2.Location = new System.Drawing.Point(12, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 173);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recent Games";
            // 
            // recentGamesListView
            // 
            this.recentGamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Game,
            this.Pick,
            this.Show,
            this.Decide,
            this.Result});
            this.recentGamesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentGamesListView.Location = new System.Drawing.Point(3, 16);
            this.recentGamesListView.Name = "recentGamesListView";
            this.recentGamesListView.Size = new System.Drawing.Size(499, 154);
            this.recentGamesListView.TabIndex = 0;
            this.recentGamesListView.UseCompatibleStateImageBehavior = false;
            this.recentGamesListView.View = System.Windows.Forms.View.Details;
            // 
            // Game
            // 
            this.Game.Text = "Game";
            this.Game.Width = 53;
            // 
            // Pick
            // 
            this.Pick.Text = "First Pick";
            this.Pick.Width = 66;
            // 
            // Show
            // 
            this.Show.Text = "Monty Shown";
            this.Show.Width = 80;
            // 
            // Decide
            // 
            this.Decide.Text = "Final Decision";
            this.Decide.Width = 89;
            // 
            // Result
            // 
            this.Result.Text = "Win?";
            this.Result.Width = 66;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "montyhallhistory.csv";
            this.saveFileDialog1.Filter = "\"Comma Seperated Values|*.csv\"";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // simulateToolStripMenuItem
            // 
            this.simulateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulateManyToolStripMenuItem});
            this.simulateToolStripMenuItem.Name = "simulateToolStripMenuItem";
            this.simulateToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.simulateToolStripMenuItem.Text = "Simulate";
            // 
            // simulateManyToolStripMenuItem
            // 
            this.simulateManyToolStripMenuItem.Name = "simulateManyToolStripMenuItem";
            this.simulateManyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.simulateManyToolStripMenuItem.Text = "Simulate Many";
            this.simulateManyToolStripMenuItem.Click += new System.EventHandler(this.simulateManyToolStripMenuItem_Click);
            // 
            // door3
            // 
            this.door3.BackgroundImage = global::MontyHall.Properties.Resources.closeddoor;
            this.door3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door3.FlatAppearance.BorderSize = 2;
            this.door3.Font = new System.Drawing.Font("Consolas", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.door3.Location = new System.Drawing.Point(352, 27);
            this.door3.Name = "door3";
            this.door3.Size = new System.Drawing.Size(165, 309);
            this.door3.TabIndex = 6;
            this.door3.Text = "3";
            this.door3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.door3.UseVisualStyleBackColor = true;
            this.door3.Click += new System.EventHandler(this.DoorClick);
            // 
            // door2
            // 
            this.door2.BackgroundImage = global::MontyHall.Properties.Resources.closeddoor;
            this.door2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door2.FlatAppearance.BorderSize = 2;
            this.door2.Font = new System.Drawing.Font("Consolas", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.door2.Location = new System.Drawing.Point(181, 27);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(165, 309);
            this.door2.TabIndex = 5;
            this.door2.Text = "2";
            this.door2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.door2.UseVisualStyleBackColor = true;
            this.door2.Click += new System.EventHandler(this.DoorClick);
            // 
            // door1
            // 
            this.door1.BackgroundImage = global::MontyHall.Properties.Resources.closeddoor;
            this.door1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door1.FlatAppearance.BorderSize = 2;
            this.door1.Font = new System.Drawing.Font("Consolas", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.door1.Location = new System.Drawing.Point(10, 27);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(165, 309);
            this.door1.TabIndex = 0;
            this.door1.Text = "1";
            this.door1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.door1.UseVisualStyleBackColor = true;
            this.door1.Click += new System.EventHandler(this.DoorClick);
            // 
            // MontyHallSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(529, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.door3);
            this.Controls.Add(this.door2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.door1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(545, 644);
            this.MinimumSize = new System.Drawing.Size(545, 644);
            this.Name = "MontyHallSim";
            this.Text = "Monty Hall Simulator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button door1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNameToolStripMenuItem;
        private System.Windows.Forms.Button door2;
        private System.Windows.Forms.Button door3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel percentWonLabel;
        private System.Windows.Forms.ToolStripProgressBar displayPercent;
        private System.Windows.Forms.Label GameMessage;
        private System.Windows.Forms.ListView recentGamesListView;
        private System.Windows.Forms.ColumnHeader Game;
        private System.Windows.Forms.ColumnHeader Pick;
        private System.Windows.Forms.ColumnHeader Show;
        private System.Windows.Forms.ColumnHeader Decide;
        private System.Windows.Forms.ColumnHeader Result;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem simulateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulateManyToolStripMenuItem;
    }
}

