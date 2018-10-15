using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee:User
    {
        private DateTime employmentDate;
        public DateTime EmploymentDate
        {
            get
            {
                return employmentDate;
            }
            private set
            {
                employmentDate = value;
            }
        }
        private string post;

        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    ValidateString(ref post, value, "Incorrect post");
                }
                else
                {
                    throw new Exception("Incorrect post");
                }
            }
        }

        public int WorkExperience
        {
            get
            {
                var days = DateTime.Now - employmentDate;
                return days.Days / 365;
            }
            private set
            {

            }
        }

        public Employee(string firstName, string lastName, DateTime birthday, string post, DateTime employmentDate):base(firstName, lastName, birthday)
        {
            Post = post;
            EmploymentDate = employmentDate;
        }

        public Employee(string firstName, string lastName, string middleName, DateTime birthday, string post, DateTime employmentDate):base(firstName, lastName, middleName, birthday)
        {
            Post = post;
            EmploymentDate = employmentDate;
        }
    }
}
