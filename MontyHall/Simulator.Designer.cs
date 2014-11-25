namespace MontyHall
{
    partial class Simulator
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
            if( disposing && ( components != null ) )
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
            this.label1 = new System.Windows.Forms.Label();
            this.gameCountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.percentSwitchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many games to simulate?";
            // 
            // gameCountTextBox
            // 
            this.gameCountTextBox.Location = new System.Drawing.Point(188, 6);
            this.gameCountTextBox.Name = "gameCountTextBox";
            this.gameCountTextBox.Size = new System.Drawing.Size(53, 20);
            this.gameCountTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Percent of games to switch doors?";
            // 
            // percentSwitchTextBox
            // 
            this.percentSwitchTextBox.Location = new System.Drawing.Point(188, 36);
            this.percentSwitchTextBox.Name = "percentSwitchTextBox";
            this.percentSwitchTextBox.Size = new System.Drawing.Size(40, 20);
            this.percentSwitchTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "*Simulate will always pick door #1 first";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateGames);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "many_monty_generated.csv";
            this.saveFileDialog1.Filter = "\"Comma Seperated Values|*.csv\"";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.fileok);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "%";
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 130);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.percentSwitchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameCountTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Simulator";
            this.Text = "Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gameCountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox percentSwitchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
    }
}