using System;
using System.Collections.Generic;
using System.Text;

namespace JakubSturc.RandomAdventures
{
    public class UniformDistribution : IDistribution<double>
    {
        private readonly IRandom _rnd;

        public UniformDistribution(IRandom rnd)
        {
            _rnd = rnd;
        }

        public double Sample() => _rnd.NextDouble();
    }
}
