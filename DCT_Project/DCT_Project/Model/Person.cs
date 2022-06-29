
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
