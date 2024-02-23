using System;
using System.Collections.Generic;

namespace AquariumSimulation
{
    public class UI
    {
        private IReadOnlyAquarium _aquarium;
        private IReadOnlyList<IReadOnlyFish> _fishes;

        public UI(IReadOnlyAquarium aquarium)
        {
            _aquarium = aquarium ?? throw new ArgumentNullException(nameof(aquarium));
            _fishes = _aquarium.Fishes;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Maximum fishes count: {_aquarium.MaxCapacity}\n");

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
