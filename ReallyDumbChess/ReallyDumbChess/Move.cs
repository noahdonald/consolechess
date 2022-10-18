using System;
namespace ReallyDumbChess
{
    public class Move
    {
        public Cell current;
        public Cell dest;
        public Board board;
        public bool valid = true;

        public Move(string move, Board board)
        {
            string[] movecmd = move.Split();
            try
            {
                char[] current = movecmd[0].ToCharArray();
                char[] dest = movecmd[2].ToCharArray();
                if (int.TryParse(current[1].ToString(), out int num1) == false)
                {
                    BadMove();
                }
                if (int.TryParse(dest[1].ToString(), out int num2) == false)
                {
                    BadMove();
                }

                this.current = board.grid[num1 - 1, parseLetter(current[0].ToString())];
                this.dest = board.grid[num2 - 1, parseLetter(dest[0].ToString())];
            }
            catch (Exception ex)
            {
                BadMove();
            }
        }

        private int parseLetter(string letter)
        {
            switch (letter)
            {
                case "A":
                    return 0;
                case "B":
                    return 1;
                case "C":
                    return 2;
                case "D":
                    return 3;
                case "E":
                    return 4;
                case "F":
                    return 5;
                case "G":
                    return 6;
                case "H":
                    return 7;
                default:
                    BadMove();
                    return 0;
            }
        }

        public Cell getDest()
        {
            return dest;
        }

        public Cell getCurrent()
        {
            return current;
        }

        public void BadMove()
        {
            valid = false;
        }

        
    }
}

