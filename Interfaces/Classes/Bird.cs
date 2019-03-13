using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Classes
{
    public class Bird : ICanFly 
    {
        public string Color { get; set;  }
        public int WingSpan { get; set; }
        public int FlySpeed { get; set; }
        public int CurrentFlySpeed { get; set; }

        public void FlapWings()
        {
            this.CurrentFlySpeed += this.FlySpeed;
        }

        public void Glide()
        {
            this.CurrentFlySpeed -= this.FlySpeed;
        }
    }
}
