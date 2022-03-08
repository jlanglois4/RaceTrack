using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class JimmyJohn : Driver
    {
        public JimmyJohn(RaceCar car) : base(car)
        {
            Name = "Jimmy John";
            SkillLevel = 2;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}