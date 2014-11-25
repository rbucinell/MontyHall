using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MontyHall
{
   
    public partial class MontyHallSim : Form
    {
        private const string NEW_GAME = "Lets make a deal! Pick a door where you think the sports car is!";
        private const string MONTY_SHOW = "Monty reveals that door {0} contains a goat. Pick a door, stay with {1} or switch?";
        private const string WIN = "Congrats you win!";
        private const string LOSE = "Sorry, enjoy your new goat!";

        public Game CurrentGame { get; private set; }

        public List<Record> recentGames = new List<Record>();

        private int wins = 0, games = 0;

        public MontyHallSim()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            ResetDoor( door1 );
            ResetDoor( door2 );
            ResetDoor( door3 );
            CurrentGame = new Game();
            GameMessage.Text = NEW_GAME;
        }

        private void ResetDoor( Button door )
        {
            door.Enabled = true;
            door.BackgroundImage = Properties.Resources.closeddoor;
            door.Font = new Font( door.Font, FontStyle.Regular );
        }

        /// <summary>
        /// Take an action when a door is clicked
        /// </summary>
        private void DoorClick( object sender, EventArgs e )
        {
            Button door = (Button) sender;
            int door_num = GetDoorNum(door);

            if( CurrentGame.State == GameState.Start)
            {
                //Pick a door
                CurrentGame.PickDoor(door_num);

                //First show the user the current selection.
                door.Font = new Font( door.Font, FontStyle.Underline );
                Reveal( CurrentGame.Show );

                //Second change the game message
                GameMessage.Text = String.Format( MONTY_SHOW, CurrentGame.Show, CurrentGame.Pick );
                
            } 
            else if (CurrentGame.State == GameState.Decision)
            {
                //Pick a door
                CurrentGame.PickDoor(door_num);

                //Second change the game message
                GameMessage.Text = CurrentGame.Result ? WIN : LOSE;
                Reveal( CurrentGame.Decide );
                Reveal( CurrentGame.WinningDoor );

                //Add the results to recent games
                recentGames.Add( CurrentGame.CreateRecord() );

                //Record Keeping for wins / game
                games++;
                if (CurrentGame.Result)
                    wins++;

                //and display it
                UpdateGUI();

            }
        }

        /// <summary>
        /// Gets the door number from the passed in control
        /// </summary>
        private int GetDoorNum(Button button)
        {
            return Int32.Parse(button.Name.Substring(button.Name.Length - 1));
        }

        /// <summary>
        /// Reveals the door that Monty will show
        /// </summary>
        private void Reveal( int door )
        {
            Control c = this.Controls.Find("door" + door,true)[0];
            c.BackgroundImage = (door == CurrentGame.WinningDoor) ? Properties.Resources.openwincar : Properties.Resources.openlosedoor;
            c.Enabled = false;
        }

        /// <summary>
        /// File > NewGame action.
        /// </summary>
        private void newNameToolStripMenuItem_Click( object sender, EventArgs e )
        {
            NewGame();
        }

        private void UpdateGUI()
        {
            recentGamesListView.Items.Clear();
            int counter = 1;
            foreach (Record record in recentGames)
            {
                string[] items = record.GetItems();
                items[0] = (counter++).ToString();
                recentGamesListView.Items.Add( new ListViewItem( items ) );
            }
            int percent = (int)( ( wins / ( games * 1.0 ) ) * 100 );
            percentWonLabel.Text = String.Format("Won {0}%", percent);
            displayPercent.Value = percent;
        }

        private void exportToolStripMenuItem_Click( object sender, EventArgs e )
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk( object sender, CancelEventArgs e )
        {
            // Get file name.
            string name = saveFileDialog1.FileName;
            // Write to the file name selected.

            if( File.Exists(name))
                File.Delete( name );

            File.AppendAllText(name,"game,first pick,monty shown,final decision,win\n");
            int counter = 1;
            foreach (Record record in recentGames)
            {
                string[] items = record.GetItems();
                items[0] = (counter++).ToString();
                File.AppendAllText(name, String.Join(",", items) + Environment.NewLine );
            }
        }

        private void simulateManyToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Simulator s = new Simulator();
            s.ShowDialog();
        }

        private void quitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }
    }
}
