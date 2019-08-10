using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Models;

namespace MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        ICollection<IRepair> Repairs { get; }
    }
}
