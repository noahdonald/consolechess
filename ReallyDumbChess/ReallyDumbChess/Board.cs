using System;
namespace ReallyDumbChess
{
    public class Board
    {
        public int size = 8;
        public Cell[,] grid { get; set; }

        List<GamePiece> pieces = new List<GamePiece> {  };

        public Board()
        {
            grid = new Cell[size, size];

            for (int i=0; i<size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i,j] = new Cell(i,j);
                }
            }
        }

        public void IsLegal (Cell current, GamePiece piece)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j].legalMove = false;
                    grid[i, j].occupied = false;
                }

            }

            piece.isLegal(current, this);
        }

        public void display()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Cell c = grid[i, j];
                    

                    if (c.occupied == true)
                    {
                        foreach (GamePiece piece in pieces)
                        {
                            if (piece.position.Equals(c))
                            {
                                piece.display();
                            }
                        }
                    }
                }
            }
        }

        public void addPiece(GamePiece piece, Cell cell)
        {
            cell.occupied = true;
            pieces.Add(piece);
            piece.position = cell;

        }
    }
}

