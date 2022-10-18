using ReallyDumbChess.Pieces;
using System;
namespace ReallyDumbChess
{
    public class Board
    {
        public int size = 8;
        public Cell[,] grid { get; set; }

        List<GamePiece> pieces = new List<GamePiece> {  };

        public List<GamePiece> whiteCaptured = new List<GamePiece> { };

        public List<GamePiece> blackCaptured = new List<GamePiece> { };

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
                }

            }

            piece.isLegal(current, this);
        }

        public void display()
        {
            int k = 1;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("  ---------------------------------");
                Console.Write(k + " ");
                k++;
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

            Console.WriteLine("  ---------------------------------");
            Console.WriteLine("    A   B   C   D   E   F   G   H");
            Console.WriteLine("=====================================");
        }

        public void addPiece(Cell cell,GamePiece piece)
        {
            cell.occupied = true;
            pieces.Add(piece);
            piece.position = cell;

        }

        public GamePiece getPiece(Cell cell)
        {
            GamePiece gamePiece = null;
            foreach (GamePiece piece in pieces)
            {
                if (piece.position == cell)
                {
                    gamePiece = piece;
                }
                
            }
            return gamePiece;
        }

        public void capturePiece(Cell cell)
        {
            GamePiece piece = getPiece(cell);
            if (piece.playerColor == PlayerColor.White)
            {
                blackCaptured.Add(piece);
            }
            else
            {
                whiteCaptured.Add(piece);
            }
            pieces.Remove(piece);
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
            addPiece(grid[7, 0], new Rook(PlayerColor.White));
            addPiece(grid[7, 1], new Knight(PlayerColor.White));
            addPiece(grid[7, 2], new Bishop(PlayerColor.White));
            addPiece(grid[7, 3], new Queen(PlayerColor.White));
            addPiece(grid[7, 4], new King(PlayerColor.White));
            addPiece(grid[7, 5], new Bishop(PlayerColor.White));
            addPiece(grid[7, 6], new Knight(PlayerColor.White));
            addPiece(grid[7, 7], new Rook(PlayerColor.White));

            addPiece(grid[6, 0], new Pawn(PlayerColor.White));
            addPiece(grid[6, 1], new Pawn(PlayerColor.White));
            addPiece(grid[6, 2], new Pawn(PlayerColor.White));
            addPiece(grid[6, 3], new Pawn(PlayerColor.White));
            addPiece(grid[6, 4], new Pawn(PlayerColor.White));
            addPiece(grid[6, 5], new Pawn(PlayerColor.White));
            addPiece(grid[6, 6], new Pawn(PlayerColor.White));
            addPiece(grid[6, 7], new Pawn(PlayerColor.White));

            addPiece(grid[1, 0], new Pawn(PlayerColor.Black));
            addPiece(grid[1, 1], new Pawn(PlayerColor.Black));
            addPiece(grid[1, 2], new Pawn(PlayerColor.Black));
            addPiece(grid[1, 3], new Pawn(PlayerColor.Black));
            addPiece(grid[1, 4], new Pawn(PlayerColor.Black));
            addPiece(grid[1, 5], new Pawn(PlayerColor.Black));
            addPiece(grid[1, 6], new Pawn(PlayerColor.Black));
            addPiece(grid[1, 7], new Pawn(PlayerColor.Black));

            addPiece(grid[0, 0], new Rook(PlayerColor.Black));
            addPiece(grid[0, 1], new Knight(PlayerColor.Black));
            addPiece(grid[0, 2], new Bishop(PlayerColor.Black));
            addPiece(grid[0, 3], new Queen(PlayerColor.Black));
            addPiece(grid[0, 4], new King(PlayerColor.Black));
            addPiece(grid[0, 5], new Bishop(PlayerColor.Black));
            addPiece(grid[0, 6], new Knight(PlayerColor.Black));
            addPiece(grid[0, 7], new Rook(PlayerColor.Black));
        }


    }
}

