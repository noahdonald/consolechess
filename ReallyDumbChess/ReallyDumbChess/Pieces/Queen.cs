using System;
namespace ReallyDumbChess.Pieces
{
    public class Queen : GamePiece
    {
        PlayerColor playerColor;

        public Queen(PlayerColor color)
        {
            playerColor = color;
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
            throw new NotImplementedException();
        }

        public override void move(string dest)
        {
            throw new NotImplementedException();
        }
    }
}

