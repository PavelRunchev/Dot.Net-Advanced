﻿using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Models;

namespace MilitaryElite.Interfaces
{
    public interface ICommando
    {
        ICollection<IMission> Missions { get; set; }
    }
}
