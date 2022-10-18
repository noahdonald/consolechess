using System;

namespace ReallyDumbChess.Pieces
{
    public class King : GamePiece
    {
        
        public King(PlayerColor color) : base(color)
        {
            
        }

        public override void display()
        {
            if (playerColor == PlayerColor.White)
            {
                Console.Write(" k ");
            }
            else
            {
                Console.Write(" K ");
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
                if (isSafe(current.rowNum - 1, current.columnNum))
                {
                    board.grid[current.rowNum - 1, current.columnNum].legalMove = true;
                }
                if (isSafe(current.rowNum, current.columnNum + 1))
                {
                    board.grid[current.rowNum, current.columnNum + 1].legalMove = true;
                }
                if (isSafe(current.rowNum, current.columnNum - 1))
                {
                    board.grid[current.rowNum, current.columnNum - 1].legalMove = true;
                }
                if (isSafe(current.rowNum + 1, current.columnNum - 1))
                {
                    board.grid[current.rowNum + 1, current.columnNum - 1].legalMove = true;
                }
                if (isSafe(current.rowNum - 1, current.columnNum + 1))
                {
                    board.grid[current.rowNum - 1, current.columnNum + 1].legalMove = true;
                }
                if (isSafe(current.rowNum - 1, current.columnNum - 1))
                {
                    board.grid[current.rowNum - 1, current.columnNum - 1].legalMove = true;
                }
                if (isSafe(current.rowNum + 1, current.columnNum + 1))
                {
                    board.grid[current.rowNum + 1, current.columnNum + 1].legalMove = true;
                }
            }
            else
            {
                if (isSafe(current.rowNum - 1, current.columnNum))
                {
                    board.grid[current.rowNum - 1, current.columnNum].legalMove = true;
                }
                if (isSafe(current.rowNum + 1, current.columnNum))
                {
                    board.grid[current.rowNum + 1, current.columnNum].legalMove = true;
                }
                if (isSafe(current.rowNum, current.columnNum - 1))
                {
                    board.grid[current.rowNum, current.columnNum - 1].legalMove = true;
                }
                if (isSafe(current.rowNum, current.columnNum + 1))
                {
                    board.grid[current.rowNum, current.columnNum + 1].legalMove = true;
                }
                if (isSafe(current.rowNum - 1, current.columnNum + 1))
                {
                    board.grid[current.rowNum - 1, current.columnNum + 1].legalMove = true;
                }
                if (isSafe(current.rowNum + 1, current.columnNum - 1))
                {
                    board.grid[current.rowNum + 1, current.columnNum - 1].legalMove = true;
                }
                if (isSafe(current.rowNum + 1, current.columnNum + 1))
                {
                    board.grid[current.rowNum + 1, current.columnNum + 1].legalMove = true;
                }
                if (isSafe(current.rowNum - 1, current.columnNum - 1))
                {
                    board.grid[current.rowNum - 1, current.columnNum - 1].legalMove = true;
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
            if (x < 0 || x >= 7 || y < 0 || y >= 7)
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

