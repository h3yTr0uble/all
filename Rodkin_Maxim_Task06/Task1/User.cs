using System;

namespace Task1
{
    class User
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private DateTime birthday;
        public int Age
        {
            get
            {
                var ageDays = DateTime.Now - birthday;
                Age = ageDays.Days / 365;
                return Age;
            }
            private set
            {

            }
        }

        public User(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public User(string firstName, string lastName, string middleName, DateTime birthday) : this(firstName, lastName, birthday)
        {
            MiddleName = middleName;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    ValidateString(ref firstName, value, "Incorrect first name");
                }
                else
                {
                    throw new Exception("Incorrect first name");
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    ValidateString(ref lastName, value, "Incorrect last name");
                }
                else
                {
                    throw new Exception("Incorrect last name");
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                ValidateString(ref middleName, value, "Incorrect middle name");
            }
        }

        protected void ValidateString(ref string name, string value, string ex)
        {
            value = value.Trim();
            for (int i = 0; i < value.Length; i++)
            {
                if (!(char.IsLetter(value[i]) || value[i] == '-'))
                {
                    throw new Exception(ex);
                }
            }
            name = value;
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                if (value <= DateTime.Now)
                {
                    birthday = value;
                }
                else
                {
                    throw new Exception("Incorrect birthday");
                }
            }
        }
    }
}
