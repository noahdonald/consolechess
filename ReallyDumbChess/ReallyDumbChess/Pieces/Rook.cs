using System;
namespace ReallyDumbChess.Pieces
{
    public class Rook : GamePiece
    {
        public Rook(PlayerColor color)
        {
        }

        public override void display()
        {
            Console.Write("r");
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

