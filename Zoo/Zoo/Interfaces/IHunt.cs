using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Interfaces
{
    interface IHunt
    {
        string Prey { get; set; }

        string HuntingGround();
    }
}
