using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DCT_Project
{
    public class ApplicationViewModel 
    {
        private Person _selectedPerson;
        private ObservableCollection<Person> _people = new ObservableCollection<Person>();
        public ObservableCollection<Person> People { get { return this._people; } }

        public ApplicationViewModel()
        {
            this._people = new ObservableCollection<Person>
            {
            new Person() { FirstName = "Alina", LastName = "Kotkova" },
            new Person() { FirstName = "Sergey", LastName = "Korolenko" },
            new Person() { FirstName = "Sergey", LastName = "Kolotilo" }
            };
        }
        public Person SelectedPerson
        {
            get { return this._selectedPerson; }
            set { this._selectedPerson = value; }
        }

        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                return _addCommand ??
                    (_addCommand = new RelayCommand(() =>
                    {
                        Person person = new Person();
                        People.Add(person);
                        SelectedPerson = person;
                    }));
            }
        }
        private ICommand _deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand ??
                    (_deleteCommand = new RelayCommand(() =>
                    {
                        Person person = new Person();
                        person = SelectedPerson;
                        People.Remove(person);
                    }));
            }
        }

    }

}
