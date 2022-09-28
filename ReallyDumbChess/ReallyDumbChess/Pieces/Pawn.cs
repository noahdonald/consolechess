using System;
namespace ReallyDumbChess.Pieces
{
    public class Pawn : GamePiece
    {
        PlayerColor playerColor;

        public Pawn(PlayerColor color)
        {
            playerColor = color;
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
            throw new NotImplementedException();
        }

        public override void move(string dest)
        {
            throw new NotImplementedException();
        }
    }
}

