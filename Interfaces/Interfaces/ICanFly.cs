using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICanFly    //An interface is a contract of actions
    {
        int WingSpan { get; set; }
        int FlySpeed { get; set; }
        int CurrentFlySpeed { get; set; }

        void FlapWings();

        void Glide();
    }
}
