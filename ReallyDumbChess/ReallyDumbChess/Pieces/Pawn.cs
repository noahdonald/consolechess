using System;
namespace ReallyDumbChess.Pieces
{
    public class Pawn : GamePiece
    {
        public Pawn(PlayerColor color)
        {
        }

        public override void display()
        {
            Console.Write("p");
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

