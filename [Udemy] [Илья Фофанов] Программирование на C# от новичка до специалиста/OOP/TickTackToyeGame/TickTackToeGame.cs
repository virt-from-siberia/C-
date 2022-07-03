﻿namespace OOP.TickTackToyeGame
{
    public enum WinnerEnum
    {
        Crosses,
        Zeroes,
        Draw,
        GameIsUnFinished
    }

    public enum State
    {
        Cross,
        Zero,
        Unset
    }

    public class TickTackToeGame
    {
        private readonly State[] board = new State[9];
        public int MoveCounter { get; private set; }

        public TickTackToeGame()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = State.Unset;
            }
        }

        public void MakeMove(int index)
        {
            board[index - 1] = MoveCounter % 2 == 0 ? State.Cross : State.Zero;
            MoveCounter++;
        }

        public State GetState(int index)
        {
            return board[index - 1];
        }

        public WinnerEnum GetWinner()
        {
            return GetWinner(1, 4, 7, 2, 5, 8, 3, 6, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 5, 9, 3, 5, 7);
        }

        private WinnerEnum GetWinner(params int[] indexes)
        {
            for (int i = 0; i < indexes.Length; i += 3)
            {
                bool same = AreSame(indexes[i], indexes[i + 1], indexes[i + 2]);
                if (same)
                {
                    State state = GetState(indexes[i]);
                    if (state != State.Unset)
                    {
                        return state == State.Cross ? WinnerEnum.Crosses : WinnerEnum.Zeroes;
                    }
                }
            }

            if (MoveCounter < 9)
                return WinnerEnum.GameIsUnFinished;
            return WinnerEnum.Draw;
        }

        private bool AreSame(int a, int b, int c)
        {
            return GetState(a) == GetState(b) && GetState(a) == GetState(c);
        }
    };
}