using System.Collections.Generic;

namespace AquariumSimulation
{
    public interface IReadOnlyFishes
    {
        IReadOnlyList<IReadOnlyLifetime> Fishes { get; }

        int MaxFishesCount { get; }
    }
}