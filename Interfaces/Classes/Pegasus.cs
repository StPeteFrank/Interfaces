using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Classes
{
    public class Pegasus : ICanGallop, ICanFly
    {
        public int WingSpan { get ; set ; }
        public int FlySpeed { get ; set ; }
        public int CurrentFlySpeed { get ; set ; }
        public int NumberOfShoes { get ; set ; }
        public int MaxSpeed { get ; set ; }

        public void DecreaseSpeed(int decel)
        {
            this.MaxSpeed -= decel * 2;
        }

        public void FlapWings()
        {
            this.CurrentFlySpeed += this.FlySpeed * 2;
        }

        public void Glide()
        {
            this.CurrentFlySpeed -= this.FlySpeed;
        }

        public void IncreaseSpeed(int accel)
        {
            this.MaxSpeed += accel * 2;
        }
    }
}
