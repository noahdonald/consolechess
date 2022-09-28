using System;
namespace ReallyDumbChess.Pieces
{
    public class Bishop :GamePiece
    {
        public Bishop(PlayerColor color)
        {
        }

        public override void display()
        {
            Console.Write("b");
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

