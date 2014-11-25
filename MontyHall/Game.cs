using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;

namespace MontyHall
{
    public enum GameState
    {
        Start,
        Decision,
        Final
    }


    public class Game
    {

        public GameState State { get; set; }

        /// <summary>
        /// The initial pick.
        /// </summary>
        public int Pick { get; private set; }

        /// <summary>
        /// The door that monty shows.
        /// </summary>
        public int Show { get; private set; }

        /// <summary>
        /// The door the user settles on
        /// </summary>
        public int Decide { get; private set; }

        /// <summary>
        /// Did the user win?
        /// </summary>
        public bool Result { get; private set; }

        /// <summary>
        /// Winning Door. Shhh
        /// </summary>
        public int WinningDoor { get; private set; }

        private static readonly Random random = new Random();

        /// <summary>
        /// Creates game
        /// </summary>
        public Game()
        {
            State = GameState.Start;
            WinningDoor = random.Next( 1, 4 );
        }

        /// <summary>
        /// Player picks a door.
        /// </summary>
        /// <param name="door"></param>
        public void PickDoor(int door)
        {
            if (State == GameState.Start)
            {
                Pick = door;
                Show = DeterimeDoorForMonty();
                State = GameState.Decision; 
            }
            else if( State == GameState.Decision )
            {
                Decide = door;
                Result = (Decide == WinningDoor);
                State = GameState.Final;
            }
        }

        /// <summary>
        /// computer decides which door to show
        /// </summary>
        /// <returns></returns>
        private int DeterimeDoorForMonty()
        {
            List<int> remaingDoors = new List<int>();
            for (int i = 1; i <= 3; i++)
            {
                if (i != Pick && i != WinningDoor)
                {
                    remaingDoors.Add(i);
                }
            }
            return Pick == WinningDoor ? remaingDoors[random.Next(0, 2)] : remaingDoors[0];
        }

        public Record CreateRecord()
        {
            return new Record(Pick,Show,Decide, Result);
        }
    }
}
