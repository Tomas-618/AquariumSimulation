using System;
using System.Collections.Generic;

namespace AquariumSimulation
{
    public class Aquarium : IReadOnlyFishes
    {
        private readonly int _maxFishesCount;

        private List<Fish> _fishes;

        public Aquarium(in int maxFishesCount)
        {
            if (maxFishesCount <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(maxFishesCount)}: {maxFishesCount}");

            _maxFishesCount = maxFishesCount;
            Fill();
        }

        public IReadOnlyList<IReadOnlyLifetime> Fishes => _fishes;

        public int MaxFishesCount => _maxFishesCount;

        public bool IsFull => _fishes.Count == _maxFishesCount;

        public void AddFish(Fish fish)
        {
            if (fish == null)
                throw new ArgumentNullException(nameof(fish));
            
            if (IsFull)
            {
                Console.WriteLine($"Can't add more fishes, because {nameof(Aquarium).ToLower()} is full of them");

                return;
            }

            _fishes.Add(fish);
        }

        public void RemoveFishByIndex(int fishIndex)
        {
            if (_fishes.ContainsKey(fishIndex) == false)
            {
                Console.WriteLine("Can't find the fish");

                return;
            }

            _fishes.RemoveAt(fishIndex);
        }

        public void GrowOldAllFishes()
        {
            foreach (Fish fish in _fishes)
                fish.GrowOld();

            RemoveDiedFishes();
        }

        private void RemoveDiedFishes() =>
            _fishes.RemoveAll(fish => fish.IsDead);

        private void Fill() =>
            _fishes = new List<Fish>();
    }
}
