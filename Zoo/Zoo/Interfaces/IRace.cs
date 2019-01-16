using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Interfaces
{
    interface IRace
    {
        bool WearBlinders { get; set; }

        string Race();
    }
}
