namespace JakubSturc.RandomAdventures
{
    public interface IDistribution<T>
    {
        T Sample();
    }
}
