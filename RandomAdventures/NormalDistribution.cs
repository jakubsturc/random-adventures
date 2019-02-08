using System;
using System.Collections.Generic;
using System.Text;

using static System.Math;

namespace JakubSturc.RandomAdventures
{
    public class NormalDistribution : IDistribution<double>
    {
        public double Mean { get; }
        public double Sigma { get; }
        public double μ => Mean;
        public double σ => Sigma;

        private UniformDistribution _uniformDistribution;
        
        public NormalDistribution(IRandom rnd, double mean, double sigma)
        {
            Mean = mean;
            Sigma = sigma;

            _uniformDistribution = new UniformDistribution(rnd);
        }

        // Box-Muller method
        private double StandardSample() => 
            Sqrt(-2.0 * Log(_uniformDistribution.Sample())) 
            * Cos(2.0 * PI * _uniformDistribution.Sample());

        public double Sample() => μ + σ * StandardSample();
    }
}
