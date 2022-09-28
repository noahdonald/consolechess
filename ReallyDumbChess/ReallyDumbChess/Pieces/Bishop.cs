using System;
namespace ReallyDumbChess.Pieces
{
    public class Bishop :GamePiece
    {
        PlayerColor playerColor;

        public Bishop(PlayerColor color)
        {
            playerColor = color;
        }

        public override void display()
        {
            if (playerColor == PlayerColor.White)
            {
                Console.Write(" b ");
            }
            else
            {
                Console.Write(" B ");
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

