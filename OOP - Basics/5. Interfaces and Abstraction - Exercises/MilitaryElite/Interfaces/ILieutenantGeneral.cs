using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Models;

namespace MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral
    {
        ICollection<IPrivate> Privates { get; }
    }
}
