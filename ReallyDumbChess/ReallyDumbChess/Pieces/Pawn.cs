using System;
using System.Drawing;

namespace ReallyDumbChess.Pieces
{
    public class Pawn : GamePiece
    {
        
        public Pawn(PlayerColor color) : base(color)
        {
            
        }

        public override void display()
        {
            if (playerColor == PlayerColor.White)
            {
                Console.Write(" p ");
            }
            else
            {
                Console.Write(" P ");
            }
        }

        public override void isLegal(Cell current, Board board)
        {
            if (playerColor == PlayerColor.Black)
            {
                if (isSafe(current.rowNum + 1, current.columnNum))
                {
                    board.grid[current.rowNum + 1, current.columnNum].legalMove = true;
                }
                if (isSafe(current.rowNum + 1, current.columnNum + 1))
                {
                    if (board.grid[current.rowNum + 1, current.columnNum + 1].occupied == true)
                    {
                        board.grid[current.rowNum + 1, current.columnNum + 1].legalMove = true;
                    }
                }
                if (isSafe(current.rowNum + 1, current.columnNum - 1))
                {
                    if (board.grid[current.rowNum + 1, current.columnNum - 1].occupied == true)
                    {
                        board.grid[current.rowNum + 1, current.columnNum - 1].legalMove = true;
                    }
                }
            }
            else
            {
                if (isSafe(current.rowNum - 1, current.columnNum))
                {
                    board.grid[current.rowNum - 1, current.columnNum].legalMove = true;
                }
                if (isSafe(current.rowNum - 1, current.columnNum - 1))
                {
                    if (board.grid[current.rowNum - 1, current.columnNum - 1].occupied == true)
                    {
                        board.grid[current.rowNum - 1, current.columnNum - 1].legalMove = true;
                    }
                }
                if (isSafe(current.rowNum - 1, current.columnNum + 1))
                {
                    if (board.grid[current.rowNum - 1, current.columnNum + 1].occupied == true)
                    {
                        board.grid[current.rowNum - 1, current.columnNum + 1].legalMove = true;
                    }
                }
            }
        }

        public override void move(Cell dest)
        {
            position.occupied = false;
            position = dest;
            dest.occupied = true;
        }

        public bool isSafe(int x, int y)
        {
            if (x < 0 || x > 7 || y < 0 || y > 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

