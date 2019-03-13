using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Classes
{
   public class Horse: ICanGallop
    {
        public int NumberOfShoes { get; set; }
        public string ManeColor { get; set; }
        public string Breed { get; set; }
        public int MaxSpeed { get; set; }

        public void DecreaseSpeed(int decel)
        {
            this.MaxSpeed -= decel;
        }

        public void IncreaseSpeed(int accel)
        {
            this.MaxSpeed += accel;
        }
    }
}
