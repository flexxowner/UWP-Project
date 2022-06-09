using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCT_Project
{
    public class ApplicationViewModel
    {
        private ObservableCollection<Person> people = new ObservableCollection<Person>();
        public ObservableCollection<Person> People { get { return this.people; } }

        public ApplicationViewModel()
        {
            this.people.Add(new Person() { FirstName = "Alina", LastName = "Kotkova" });
            this.people.Add(new Person() { FirstName = "Sergey", LastName = "Korolenko" });
            this.people.Add(new Person() { FirstName = "Sergey", LastName = "Kolotilo" });
        }
    }
}
