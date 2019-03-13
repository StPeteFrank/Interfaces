﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICanFly
    {
        int WingSpan { get; set; }
        int FlySpeed { get; set; }
        int CurrentFlySpeed { get; set; }

        void FlapWings();

        void Glide();
    }
}
