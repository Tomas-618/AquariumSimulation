using System;

namespace AquariumSimulation
{
    public class Fish : IReadOnlyLifetime
    {
        private readonly int _maxLifetime;

        public Fish(in int lifetime)
        {
            _maxLifetime = 60;
            Fill(lifetime);
        }

        public int Lifetime { get; private set; }

        public bool IsDead => Lifetime <= 0;

        public void GrowOld() =>
            Lifetime--;

        public override string ToString() =>
            $"Lifetime: {Lifetime}";

        private void Fill(in int age)
        {
            if (age <= 0 || age > _maxLifetime)
                throw new ArgumentOutOfRangeException($"{nameof(age)}: {age}");

            Lifetime = age;
        }
    }
}
