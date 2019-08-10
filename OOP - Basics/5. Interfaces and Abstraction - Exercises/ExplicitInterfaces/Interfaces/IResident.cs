using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Interfaces
{
    interface IResident
    {
        string Name { get; }
        string Country { get; }

        string GetName();
    }
}
