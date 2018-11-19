using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Department.DAL
{
    public interface IAwardDAO
    {
        void Add(Entities.Award user);
        void Remove(Entities.Award user);
        System.Collections.Generic.List<Entities.Award> GetList();
    }
}
