using System;
namespace ReallyDumbChess
{
    public abstract class GamePiece 
    {
        public Cell position;

        public PlayerColor color
        {
            set; get;
        }

        abstract public void move(string dest);

        abstract public void isLegal(Cell current, Board board);

        abstract public void display();
    }
}

