using System;
namespace ReallyDumbChess.Pieces
{
    public class Queen : GamePiece
    {
        public Queen(PlayerColor color)
        {
        }

        public override void display()
        {
            Console.Write("q");
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

