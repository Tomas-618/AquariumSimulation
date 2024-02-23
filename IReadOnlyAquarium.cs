using System.Collections.Generic;

namespace AquariumSimulation
{
    public interface IReadOnlyAquarium
    {
        IReadOnlyList<IReadOnlyFish> Fishes { get; }

        int MaxCapacity { get; }

        bool IsFull { get; }
    }
}