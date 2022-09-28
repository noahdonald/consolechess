using System;
namespace ReallyDumbChess.Pieces
{
    public class King : GamePiece
    {
        public King(PlayerColor color)
        {
        }

        public override void display()
        {
            Console.Write("k");
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

