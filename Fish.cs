using System;

namespace AquariumSimulation
{
    public class Fish : IReadOnlyFish
    {
        private readonly int _maxLifetime;

        public Fish(in int lifetime)
        {
            _maxLifetime = 60;

            if (lifetime <= 0 || lifetime > _maxLifetime)
                throw new ArgumentOutOfRangeException($"{nameof(lifetime)}: {lifetime}");

            Lifetime = lifetime;
        }

        public int Lifetime { get; private set; }

        public bool IsDead => Lifetime <= 0;

        public void GrowOld() =>
            Lifetime--;

        public override string ToString() =>
            $"Lifetime: {Lifetime}";
    }
}
