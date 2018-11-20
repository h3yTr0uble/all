using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Department.DAL
{
	public class UserDAO : IUserDAO
	{
		private List<User> users = new List<User>();

		public void Add(User user)
		{
			if (user == null)
				throw new ArgumentException("User");

			users.Add(user);
		}

        public void Remove(User user)
        {
            if (user == null)
                throw new ArgumentException("User");

            users.Remove(user);
        }

        public IEnumerable<User> GetList()
		{
			return users;
		}

        public void Edit(User user)
        {
            throw new NotImplementedException();
        }
    }
}
