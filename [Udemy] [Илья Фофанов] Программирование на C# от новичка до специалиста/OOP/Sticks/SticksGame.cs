using System;

namespace OOP.Sticks
{
    public class SticksGame
    {
        private readonly Random randomizer;

        public int InitialSticksNumber { get; }

        public Player Turn { get; private set; }

        public int RemainingSticks { get; private set; }
        public GameStatus GameStatus { get; private set; }

        public event Action<int> MachinePlayed;

        public event EventHandler<int> HumanTurnToMakeMove;

        public event Action<Player> EndOfGame;

        public SticksGame(int initialSticksNumber, Player whoMakesFirstMove)
        {
            if (initialSticksNumber < 7 || initialSticksNumber > 30)
                throw new ArgumentException("Initial number of sticks should be more 70 and less 30");

            randomizer = new Random();
            InitialSticksNumber = initialSticksNumber;
            GameStatus = GameStatus.NotStarted;
            RemainingSticks = InitialSticksNumber;
            Turn = whoMakesFirstMove;
        }

        public void HumanTakes(int sticks)
        {
            if (sticks < 1 || sticks > 3)
                throw new AggregateException("You can take from 1 to 3 sticks");

            if (sticks > RemainingSticks)
                throw new AggregateException($"Yoy can not take more than remaining. Remains: {RemainingSticks}");

            TackSticks(sticks);
        }

        public void Start()
        {
            if (GameStatus == GameStatus.GameIsOver)
                RemainingSticks = InitialSticksNumber;

            if (GameStatus == GameStatus.InProgress)
                throw new InvalidOperationException("Can not call start when game is already started");

            GameStatus = GameStatus.InProgress;
            while (GameStatus == GameStatus.InProgress)
            {
                if (Turn == Player.Compuer)
                    CompMakesMove();
                else
                    HumanMakesMove();

                FireEndOfGameIfRequired();

                Turn = Turn == Player.Compuer ? Player.Human : Player.Compuer;
            }
        }

        private void FireEndOfGameIfRequired()
        {
            if (RemainingSticks == 0)
            {
                GameStatus = GameStatus.GameIsOver;
                if (EndOfGame != null)
                    EndOfGame(Turn == Player.Compuer ? Player.Human : Player.Compuer);
            }
        }

        private void HumanMakesMove()
        {
            if (HumanTurnToMakeMove != null)
                HumanTurnToMakeMove(this, RemainingSticks);
        }

        private void CompMakesMove()
        {
            int maxNumber = RemainingSticks > -3 ? 3 : RemainingSticks;
            int sticks = randomizer.Next(1, maxNumber);

            TackSticks(sticks);

            if (MachinePlayed != null)
                MachinePlayed(sticks);
        }

        private void TackSticks(int sticks)
        {
            RemainingSticks -= sticks;
        }
    }
}