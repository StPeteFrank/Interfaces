using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Classes
{
    public class Pegasus : Horse, ICanFly
    {
        public int WingSpan { get ; set ; }
        public int FlySpeed { get ; set ; }
        public int CurrentFlySpeed { get ; set ; }

        public void FlapWings()
        {
            this.CurrentFlySpeed += this.FlySpeed = 2;
        }

        public void Glide()
        {
            this.CurrentFlySpeed -= this.FlySpeed;
        }
    }
}
