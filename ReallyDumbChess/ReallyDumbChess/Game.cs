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
            currentPlayer = PlayerColor.White;
        }
    }
}

