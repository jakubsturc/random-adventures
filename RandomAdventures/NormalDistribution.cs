using static System.Math;

namespace JakubSturc.RandomAdventures
{
    public class NormalDistribution : IDistribution<double>
    {
        public double μ { get; }
        public double σ { get; }

        private UniformDistribution _uniformDistribution;
        
        public NormalDistribution(IRandom rnd, double mean, double sigma)
        {
            μ = mean;
            σ = sigma;

            _uniformDistribution = new UniformDistribution(rnd);
        }

        // Box-Muller method
        private double StandardSample() => 
            Sqrt(-2.0 * Log(_uniformDistribution.Sample())) 
            * Cos(2.0 * PI * _uniformDistribution.Sample());

        public double Sample() => μ + σ * StandardSample();
    }
}
