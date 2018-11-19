using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Department.DAL
{
    public class AwardDAO:IAwardDAO
    {
        private List<Award> awards = new List<Award>();

        public void Add(Award award)
        {
            if (award == null)
                throw new ArgumentException("Award");

            awards.Add(award);
        }

        public void Remove(Award award)
        {
            if (award == null)
                throw new ArgumentException("Award");

            awards.Remove(award);
        }


        public List<Award> GetList()
        {
            return awards;
        }
    }
}
