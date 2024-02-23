using System;

namespace AquariumSimulation
{
    public class UI
    {
        private IReadOnlyFishes _readOnlyFishes;

        public UI(IReadOnlyFishes readOnlyFishes) =>
            Fill(readOnlyFishes);

        public void ShowInfo()
        {
            Console.WriteLine($"Maximum fishes count: {_readOnlyFishes.MaxFishesCount}\n");

            if (_readOnlyFishes.Fishes.Count == 0)
            {
                Console.WriteLine("There's no fishes now :(");

                return;
            }

            for (int i = 0; i < _readOnlyFishes.Fishes.Count; i++)
            {
                int index = i + 1;

                Console.WriteLine($"{index}) {_readOnlyFishes.Fishes[i]}");
            }
        }

        private void Fill(IReadOnlyFishes readOnlyFishes)
        {
            if (readOnlyFishes == null)
                throw new ArgumentNullException(nameof(readOnlyFishes));

            _readOnlyFishes = readOnlyFishes;
        }
    }
}
