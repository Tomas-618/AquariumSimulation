using System;

namespace AquariumSimulation
{
    public class FishFarmer
    {
        private Aquarium _aquarium;
        private UI _aquariumUI;

        public FishFarmer() =>
            Initialize();

        public void Work()
        {
            const string AddFishCommand = "0";
            const string RemoveFishCommand = "1";
            const string ExitCommand = "2";

            bool isWorking = true;

            Console.Clear();

            while (isWorking)
            {
                _aquariumUI.ShowInfo();

                Console.WriteLine($"\nAdd fish - {AddFishCommand}");
                Console.WriteLine($"Remove fish - {RemoveFishCommand}");
                Console.WriteLine($"Exit - {ExitCommand}\n");

                Console.WriteLine("What do you want to do?");
                string userInput = Console.ReadLine();

                _aquarium.GrowOldAllFishes();

                switch (userInput)
                {
                    case AddFishCommand:
                        CreateFish();
                        break;

                    case RemoveFishCommand:
                        RemoveFish();
                        break;

                    case ExitCommand:
                        isWorking = false;
                        continue;

                    default:
                        Console.WriteLine("Unknown action!");
                        break;
                }

                ConsoleUtils.WaitForClick();
                Console.Clear();
            }
        }

        private void CreateFish()
        {
            int lifetime = ConsoleUtils.GetNumber("Lifetime: ");

            _aquarium.AddFish(new Fish(lifetime));
        }

        private void RemoveFish()
        {
            int fishIndex = ConsoleUtils.GetNumber("Fish index: ");

            _aquarium.RemoveFishByIndex(fishIndex - 1);
        }

        private void Initialize()
        {
            int maxFishesCount = ConsoleUtils.GetNumber("Maximum fishes count: ");

            _aquarium = new Aquarium(maxFishesCount);
            _aquariumUI = new UI(_aquarium.Fishes, _aquarium.MaxFishesCount);
        }
    }
}
