using System;
namespace ReallyDumbChess.Pieces
{
    public class Queen : GamePiece
    {
        
        public Queen(PlayerColor color) : base(color)
        {
            
        }

        public override void display()
        {
            if (playerColor == PlayerColor.White)
            {
                Console.Write(" q ");
            }
            else
            {
                Console.Write(" Q ");
            }
        }

        public override void isLegal(Cell current, Board board)
        {
            if (playerColor == PlayerColor.Black)
            {
                for (int i = 0; i < board.size; i++)
                {
                    if (isSafe(current.rowNum + i, current.columnNum))
                    {
                        board.grid[current.rowNum + i, current.columnNum].legalMove = true;
                    }
                    if (isSafe(current.rowNum - i, current.columnNum))
                    {
                        board.grid[current.rowNum - i, current.columnNum].legalMove = true;
                    }
                    if (isSafe(current.rowNum, current.columnNum + i))
                    {
                        board.grid[current.rowNum, current.columnNum + i].legalMove = true;
                    }
                    if (isSafe(current.rowNum, current.columnNum - i))
                    {
                        board.grid[current.rowNum, current.columnNum - i].legalMove = true;
                    }
                    if (isSafe(current.rowNum - i, current.columnNum - i))
                    {
                        board.grid[current.rowNum - i, current.columnNum - i].legalMove = true;
                    }
                    if (isSafe(current.rowNum + i, current.columnNum + i))
                    {
                        board.grid[current.rowNum + i, current.columnNum + i].legalMove = true;
                    }
                    if (isSafe(current.rowNum + i, current.columnNum - i))
                    {
                        board.grid[current.rowNum + i, current.columnNum - i].legalMove = true;
                    }
                    if (isSafe(current.rowNum - i, current.columnNum + i))
                    {
                        board.grid[current.rowNum - i, current.columnNum + i].legalMove = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < board.size; i++)
                {
                    if (isSafe(current.rowNum - i, current.columnNum))
                    {
                        board.grid[current.rowNum - i, current.columnNum].legalMove = true;
                    }
                    if (isSafe(current.rowNum + i, current.columnNum))
                    {
                        board.grid[current.rowNum + i, current.columnNum].legalMove = true;
                    }
                    if (isSafe(current.rowNum, current.columnNum - i))
                    {
                        board.grid[current.rowNum, current.columnNum - i].legalMove = true;
                    }
                    if (isSafe(current.rowNum, current.columnNum + i))
                    {
                        board.grid[current.rowNum, current.columnNum + i].legalMove = true;
                    }
                    if (isSafe(current.rowNum + i, current.columnNum + i))
                    {
                        board.grid[current.rowNum + i, current.columnNum + i].legalMove = true;
                    }
                    if (isSafe(current.rowNum - i, current.columnNum - i))
                    {
                        board.grid[current.rowNum - i, current.columnNum - i].legalMove = true;
                    }
                    if (isSafe(current.rowNum - i, current.columnNum + i))
                    {
                        board.grid[current.rowNum - i, current.columnNum + i].legalMove = true;
                    }
                    if (isSafe(current.rowNum + i, current.columnNum - i))
                    {
                        board.grid[current.rowNum + i, current.columnNum - i].legalMove = true;
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

