using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICanGallop
    {
        int NumberOfShoes { get; set; }
        int MaxSpeed { get; set; }

        void IncreaseSpeed(int accel);
        void DecreaseSpeed(int decel);
    }
}
