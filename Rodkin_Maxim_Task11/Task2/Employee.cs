using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Employee : User, IEquatable<Employee>
    {
        public DateTime EmploymentDate { get; private set; }
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
                var days = DateTime.Now - EmploymentDate;
                return days.Days / 365;
            }
            private set
            {

            }
        }

        public Employee(string firstName, string lastName, DateTime birthday, string post, DateTime employmentDate) : base(firstName, lastName, birthday)
        {
            Post = post;
            EmploymentDate = employmentDate;
        }

        public Employee(string firstName, string lastName, string middleName, DateTime birthday, string post, DateTime employmentDate) : base(firstName, lastName, middleName, birthday)
        {
            Post = post;
            EmploymentDate = employmentDate;
        }

        public override int GetHashCode()
        {
            var hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + FirstName.GetHashCode();
            hashCode = hashCode * -1521134295 + LastName.GetHashCode();
            if (MiddleName != null)
            {
                hashCode = hashCode * -1521134295 + MiddleName.GetHashCode();
            }
            hashCode = hashCode * -1521134295 + Birthday.GetHashCode();
            hashCode = hashCode * -1521134295 + Post.GetHashCode();
            hashCode = hashCode * -1521134295 + EmploymentDate.GetHashCode();
            return hashCode;
        }

        public bool Equals(Employee otherEmployee)
        {
            if (this.GetHashCode() == otherEmployee.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
