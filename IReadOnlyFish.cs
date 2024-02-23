namespace AquariumSimulation
{
    public interface IReadOnlyFish
    {
        int Lifetime { get; }

        bool IsDead { get; }
    }
}