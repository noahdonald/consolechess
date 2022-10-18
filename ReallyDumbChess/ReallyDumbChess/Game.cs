using System;
using System.Xml;
using ReallyDumbChess.Pieces;

namespace ReallyDumbChess
{
    public enum PlayerColor
    {
        White, Black
    }

    public class Game
    {
        public PlayerColor currentPlayer;
        public Board board;

        public Game()
        {
            board = new Board();
            currentPlayer = PlayerColor.Black;
            board.display();
            nextTurn(board);
        }

        public void nextTurn(Board board)
        {
            this.board = board;
            if (currentPlayer == PlayerColor.White)
            {
                currentPlayer = PlayerColor.Black;
                Console.WriteLine("Black's move:");
            }
            else
            {
                currentPlayer = PlayerColor.White;
                Console.WriteLine("White's move:");
            }

            Move move = new Move(Console.ReadLine(), board);

            while (move.valid == false)
            {
                Console.WriteLine("Illegal move entry. Please verify move is legal, within bounds, and entry follows the format 'current - destination'. Ex: A1 - B2.");
                move = new Move(Console.ReadLine(), board);
            }

            GamePiece piece = board.getPiece(move.getCurrent());
            board.IsLegal(move.getCurrent(), piece);

            while (move.dest.legalMove == false || piece.playerColor != currentPlayer)
            {
                Console.WriteLine("Illegal move entry. Please verify move is legal, within bounds, and entry follows the format 'current - destination'. Ex: A1 - B2.");
                move = new Move(Console.ReadLine(), board);
            }

            if (move.getDest().occupied == true)
            {
                board.capturePiece(move.getDest());
            }
            piece.move(move.getDest());
            board.display();
            if (board.whiteCaptured.Count > 0)
            {
                Console.Write("White Captured: ");
                foreach (GamePiece captured in board.whiteCaptured)
                {
                    captured.display();
                }
                Console.WriteLine();
            }
            if (board.blackCaptured.Count > 0)
            {
                Console.Write("Black Captured: ");
                foreach (GamePiece captured in board.blackCaptured)
                {
                    captured.display();
                }
                Console.WriteLine();
            }

            if (board.whiteCaptured.OfType<King>().Any())
            {
                Console.WriteLine("White wins!!");
            }

            else if (board.blackCaptured.OfType<King>().Any())
            {
                Console.WriteLine("Black wins!!");
            }

            else
            {
                nextTurn(board);
            }
        }
    }
}

