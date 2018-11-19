using System;
using Department.DAL;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Department.BLL
{
    public class AwardBL
    {
        private readonly IAwardDAO awardsDAO;

        public AwardBL()
        {
            awardsDAO = new AwardDAO();
        }

        public IEnumerable<Award> InitList()
        {
            Add(new Award("Нобелевская премия", "Лучшая награда"));
            Add(new Award("Премия Дарвина", "Хорошая награда"));
            return GetList();
        }

        public IEnumerable<Award> SortAwardsByTitleAsc()
        {
            return (from s in GetList()
                    orderby s.Title ascending
                    select s).ToList();
        }

        public IEnumerable<Award> SortAwardsByTitleDesc()
        {
            return (from s in GetList()
                    orderby s.Title descending
                    select s).ToList();
        }

      
        public void Add(string title, string description)
        {
            Award award = new Award(title, description);
            Add(award);
        }

        public void Add(Award award)
        {
            if (award == null)
                throw new ArgumentException("award");

            awardsDAO.Add(award);
        }

        public void Remove(Award award)
        {
            if (award == null)
                throw new ArgumentException("award");

            awardsDAO.Remove(award);
        }

        public void Remove(Award award, UserBL users)
        {
            this.Remove(award);
            foreach (var user in users.GetList())
            {
                user.RemoveAward(award);
            }
        }

        public List<Award> GetList()
        {
            return awardsDAO.GetList();
        }
    }
}
