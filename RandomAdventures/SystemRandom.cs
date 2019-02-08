using System;

namespace JakubSturc.RandomAdventures
{
    public class SystemRandom : IRandom
    {
        private readonly Random _rnd;

        public SystemRandom()
        {
            _rnd = new Random();
        }

        public SystemRandom(int seed)
        {
            _rnd = new Random(seed);
        }

        public double NextDouble() => _rnd.NextDouble();

        public int NextInt() => _rnd.Next();
    }
}
