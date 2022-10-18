using System;
using ReallyDumbChess;
namespace ReallyDumbChess.Pieces
{
    public class Knight : GamePiece
    {
        
        public Knight(PlayerColor color) : base(color)
        {
            
        }

        public override void isLegal(Cell current, Board board)
        {
            if (playerColor == PlayerColor.Black)
            {
                if (isSafe(current.rowNum + 2, current.columnNum + 1))
                {
                    board.grid[current.rowNum + 2, current.columnNum + 1].legalMove = true;
                }
                if (isSafe(current.rowNum + 2, current.columnNum - 1))
                {
                    board.grid[current.rowNum + 2, current.columnNum - 1].legalMove = true;
                }
                if (isSafe(current.rowNum - 2, current.columnNum + 1))
                {
                    board.grid[current.rowNum - 2, current.columnNum + 1].legalMove = true;
                }
                if (isSafe(current.rowNum - 2, current.columnNum - 1))
                {
                    board.grid[current.rowNum - 2, current.columnNum - 1].legalMove = true;
                }
                if (isSafe(current.rowNum + 1, current.columnNum + 2))
                {
                    board.grid[current.rowNum + 1, current.columnNum + 2].legalMove = true;
                }
                if (isSafe(current.rowNum + 1, current.columnNum - 2))
                {
                    board.grid[current.rowNum + 1, current.columnNum - 2].legalMove = true;
                }
                if (isSafe(current.rowNum - 1, current.columnNum + 2))
                {
                    board.grid[current.rowNum - 1, current.columnNum + 2].legalMove = true;
                }
                if (isSafe(current.rowNum - 1, current.columnNum - 2))
                {
                    board.grid[current.rowNum - 1, current.columnNum - 2].legalMove = true;
                }
            }
            else
            {
                if (isSafe(current.rowNum - 2, current.columnNum - 1))
                {
                    board.grid[current.rowNum - 2, current.columnNum - 1].legalMove = true;
                }
                if (isSafe(current.rowNum - 2, current.columnNum + 1))
                {
                    board.grid[current.rowNum - 2, current.columnNum + 1].legalMove = true;
                }
                if (isSafe(current.rowNum + 2, current.columnNum - 1))
                {
                    board.grid[current.rowNum + 2, current.columnNum - 1].legalMove = true;
                }
                if (isSafe(current.rowNum + 2, current.columnNum + 1))
                {
                    board.grid[current.rowNum + 2, current.columnNum + 1].legalMove = true;
                }
                if (isSafe(current.rowNum - 1, current.columnNum - 2))
                {
                    board.grid[current.rowNum - 1, current.columnNum - 2].legalMove = true;
                }
                if (isSafe(current.rowNum - 1, current.columnNum + 2))
                {
                    board.grid[current.rowNum - 1, current.columnNum + 2].legalMove = true;
                }
                if (isSafe(current.rowNum + 1, current.columnNum - 2))
                {
                    board.grid[current.rowNum + 1, current.columnNum - 2].legalMove = true;
                }
                if (isSafe(current.rowNum + 1, current.columnNum + 2))
                {
                    board.grid[current.rowNum + 1, current.columnNum + 2].legalMove = true;
                }
            }
        }

        public override void move(Cell dest)
        {
            position.occupied = false;
            position = dest;
            dest.occupied = true;
        }

        public override void display()
        {
            if (playerColor == PlayerColor.White)
            {
                Console.Write(" n ");
            }
            else
            {
                Console.Write(" N ");
            }
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

