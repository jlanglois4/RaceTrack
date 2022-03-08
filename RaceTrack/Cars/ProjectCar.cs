using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class ProjectCar : RaceCar
    {
        public ProjectCar()
        {
            Name = "Crap Box";
            TopSpeed = 500;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name}'s engine is crank-started and zooms off.");
            Position = 100;
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} spins out of control upon crossing the finish line!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"A hand is seen from the {Name}'s battered window, giving a thumbs up.");
        }
    }
}