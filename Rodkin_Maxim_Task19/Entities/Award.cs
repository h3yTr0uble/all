using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Award
    {
        private static int index = 0;
        public int Id { get;  set; }
        private string title;
       // public bool Checked { get; set; }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    title = value;
                }
                else
                {
                    throw new Exception("Incorrect title");
                }
            }
        }

        public string Description { get; set; }

        public Award(string title)
        {
            Title = title;
            Id = index;
            index++;
        }

        public Award()
        {

        }
        public Award(int id)
        {
            Id = id;
        }

        public Award(string title, string description):this(title)
        {
            Description = description;
        }

        public Award(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
