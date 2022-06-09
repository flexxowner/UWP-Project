using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCT_Project
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string OneLineSummary
        {
            get
            {
                return $"{this.FirstName} {this.LastName}";
            }
        }
    }
}
