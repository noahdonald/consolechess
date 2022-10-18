using System;
namespace ReallyDumbChess
{
    public abstract class GamePiece 
    {
        public Cell position;

        public PlayerColor playerColor
        {
            private set;
            get;
        }

        public GamePiece(PlayerColor color)
        {
            this.playerColor = color;
        }
        abstract public void move(Cell dest);

        abstract public void isLegal(Cell current, Board board);

        abstract public void display();
    }
}

