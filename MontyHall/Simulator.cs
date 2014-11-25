using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MontyHall
{
    public partial class Simulator : Form
    {
        public Simulator()
        {
            InitializeComponent();
        }

        private void fileok( object sender, CancelEventArgs e )
        {
            // Get file name.
            string name = saveFileDialog1.FileName;

            int gameCount = Int32.Parse(gameCountTextBox.Text);
            int switchCount = gameCount * Int32.Parse( percentSwitchTextBox.Text ) / 100;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("game,first pick,monty shown,final decision,win");


            for (int i = 1; i <= gameCount; i++)
            {
                Game g = new Game();
                g.PickDoor(1);

                if (switchCount > 0)
                {
                    //Switch the door, #1 is starting so if #2 is shown go #3, otherwise #2
                    g.PickDoor(g.Show == 2 ? 3 : 2);
                }
                else
                {
                    g.PickDoor(1);
                }
                switchCount--;

                string[] data = g.CreateRecord().GetItems();
                data[0] = i.ToString();
                sb.AppendLine( String.Join(",",data));
            }

            WriteFile(name, sb.ToString());

            MessageBox.Show( "Generation Complete!" );
            this.Close();
        }

        private void GenerateGames( object sender, EventArgs e )
        {
            saveFileDialog1.ShowDialog();
        }

        private void WriteFile(string filename, string data)
        {
            File.WriteAllText(filename, data);
        }
    }
}
