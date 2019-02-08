using System.Collections.Generic;

namespace JakubSturc.RandomAdventures
{
    public static class Distribution
    {
        public static IEnumerable<T> Samples<T>(this IDistribution<T> d)
        {
            while (true)
            {
                yield return d.Sample();
            }
        }

    }
}
