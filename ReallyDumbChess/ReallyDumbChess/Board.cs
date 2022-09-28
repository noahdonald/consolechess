using ReallyDumbChess.Pieces;
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
            Reset();
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
                for (int b = 0; b < size; b++)
                {
                    Console.Write("+---");
                }
                Console.Write("+");
                Console.WriteLine();
                Console.Write("|");

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
                    else
                    {
                        Console.Write("   ");
                    }
                    Console.Write("|");
                }
                
                Console.WriteLine();
            }

            for (int d = 0; d < size; d++)
            {
                Console.Write("+---");
            }
            Console.Write("+");
            Console.WriteLine();

            Console.WriteLine("=================================");
        }

        public void addPiece(Cell cell,GamePiece piece)
        {
            cell.occupied = true;
            pieces.Add(piece);
            piece.position = cell;

        }

        public void Reset()
        {
            grid = new Cell[8, 8];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j] = new Cell(i, j);
                }
            }
            addPiece(grid[0, 0], new Rook(PlayerColor.White));
            addPiece(grid[1, 0], new Knight(PlayerColor.White));
            addPiece(grid[2, 0], new Bishop(PlayerColor.White));
            addPiece(grid[3, 0], new Queen(PlayerColor.White));
            addPiece(grid[4, 0], new King(PlayerColor.White));
            addPiece(grid[5, 0], new Bishop(PlayerColor.White));
            addPiece(grid[6, 0], new Knight(PlayerColor.White));
            addPiece(grid[7, 0], new Rook(PlayerColor.White));

            addPiece(grid[0, 1], new Pawn(PlayerColor.White));
            addPiece(grid[1, 1], new Pawn(PlayerColor.White));
            addPiece(grid[2, 1], new Pawn(PlayerColor.White));
            addPiece(grid[3, 1], new Pawn(PlayerColor.White));
            addPiece(grid[4, 1], new Pawn(PlayerColor.White));
            addPiece(grid[5, 1], new Pawn(PlayerColor.White));
            addPiece(grid[6, 1], new Pawn(PlayerColor.White));
            addPiece(grid[7, 1], new Pawn(PlayerColor.White));

            addPiece(grid[0, 6], new Pawn(PlayerColor.Black));
            addPiece(grid[1, 6], new Pawn(PlayerColor.Black));
            addPiece(grid[2, 6], new Pawn(PlayerColor.Black));
            addPiece(grid[3, 6], new Pawn(PlayerColor.Black));
            addPiece(grid[4, 6], new Pawn(PlayerColor.Black));
            addPiece(grid[5, 6], new Pawn(PlayerColor.Black));
            addPiece(grid[6, 6], new Pawn(PlayerColor.Black));
            addPiece(grid[7, 6], new Pawn(PlayerColor.Black));

            addPiece(grid[0, 7], new Rook(PlayerColor.Black));
            addPiece(grid[1, 7], new Knight(PlayerColor.Black));
            addPiece(grid[2, 7], new Bishop(PlayerColor.Black));
            addPiece(grid[3, 7], new Queen(PlayerColor.Black));
            addPiece(grid[4, 7], new King(PlayerColor.Black));
            addPiece(grid[5, 7], new Bishop(PlayerColor.Black));
            addPiece(grid[6, 7], new Knight(PlayerColor.Black));
            addPiece(grid[7, 7], new Rook(PlayerColor.Black));
        }
    }
}

