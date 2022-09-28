using System;
namespace ReallyDumbChess.Pieces
{
    public class Rook : GamePiece
    {
        PlayerColor playerColor;

        public Rook(PlayerColor color)
        {
            playerColor = color;
        }

        public override void display()
        {
            if (playerColor == PlayerColor.White)
            {
                Console.Write(" r ");
            }
            else
            {
                Console.Write(" R ");
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

