using System;
using System.Collections.Generic;

namespace AquariumSimulation
{
    public class UI
    {
        private IReadOnlyList<IReadOnlyFish> _fishes;
        private int _maxFishesCount;

        public UI(IReadOnlyList<IReadOnlyFish> fishes, in int maxFishesCount)
        {
            if (maxFishesCount <= 0)
                throw new ArgumentOutOfRangeException($"{nameof(maxFishesCount)}: {maxFishesCount}");

            _fishes = fishes ?? throw new ArgumentNullException(nameof(fishes));
            _maxFishesCount = maxFishesCount;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Maximum fishes count: {_maxFishesCount}\n");

            if (_fishes.Count == 0)
            {
                Console.WriteLine("There's no fishes now :(");

                return;
            }

            for (int i = 0; i < _fishes.Count; i++)
            {
                int index = i + 1;

                Console.WriteLine($"{index}) {_fishes[i]}");
            }
        }
    }
}
