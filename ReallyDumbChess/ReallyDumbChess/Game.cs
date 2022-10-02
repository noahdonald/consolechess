using System;
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

            Move move = new Move(Console.ReadLine());

            while (move.dest.legalMove == false)
            {
                Console.WriteLine("Illegal move entry. Please verify move is legal, within bounds, and entry follows the format 'current - destination'. Ex: A1 - B2.");
                move = new Move(Console.ReadLine());
            }


        }
    }
}

