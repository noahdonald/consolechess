using System;
namespace ReallyDumbChess.Pieces
{
    public class Knight : GamePiece
    {
        public Cell position;
        PlayerColor playerColor;

        public Knight(PlayerColor color)
        {
            playerColor = color;
        }

        public override void isLegal(Cell current, Board board)
        {
            board.grid[current.rowNum + 2, current.columnNum + 1].legalMove = true;
            board.grid[current.rowNum + 2, current.columnNum - 1].legalMove = true;
            board.grid[current.rowNum - 2, current.columnNum + 1].legalMove = true;
            board.grid[current.rowNum - 2, current.columnNum - 1].legalMove = true;
            board.grid[current.rowNum + 1, current.columnNum + 2].legalMove = true;
            board.grid[current.rowNum + 1, current.columnNum - 2].legalMove = true;
            board.grid[current.rowNum - 1, current.columnNum + 2].legalMove = true;
            board.grid[current.rowNum - 1, current.columnNum - 2].legalMove = true;
        }

        public override void move(string dest)
        {
            throw new NotImplementedException();
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

    }
}

