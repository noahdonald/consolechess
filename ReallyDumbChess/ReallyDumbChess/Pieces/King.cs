using System;
namespace ReallyDumbChess.Pieces
{
    public class King : GamePiece
    {
        PlayerColor playerColor;

        public King(PlayerColor color)
        {
            playerColor = color;
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
            throw new NotImplementedException();
        }

        public override void move(string dest)
        {
            throw new NotImplementedException();
        }
    }
}

