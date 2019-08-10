using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Interfaces
{
    public interface IMyList
    {
        void Add(string item);

        void Remove();

        int Used();
    }
}
