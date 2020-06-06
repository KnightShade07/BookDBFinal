using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDBFinal
{
    class Customer
    {
        public int CustomerId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string GetDisplayText(string seperator)
        {
            return $"{CustomerId}{seperator}{FullName}{seperator}" +
                $"{Title}";
        }
    }

}
