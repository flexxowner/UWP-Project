using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DCT_Project
{
    public class ApplicationViewModel
    {
        private Person _selectedPerson;
        private readonly ObservableCollection<Person> _people = new ObservableCollection<Person>();
        public ObservableCollection<Person> People { get { return this._people; } }

        public ApplicationViewModel()
        {
            this._people = new ObservableCollection<Person>
            {
            new Person() { FirstName = "Alina", LastName = "Kotkova" },
            new Person() { FirstName = "Sergey", LastName = "Korolenko" },
            new Person() { FirstName = "Sergey", LastName = "Kolotilo" }
            };
            OpenCommand = new RelayCommand(() => IsOpen = true);
            AddCommand = new RelayCommand(AddPerson);
            DeleteCommand = new RelayCommand(DeletePerson);
        }
        public Person SelectedPerson
        {
            get { return this._selectedPerson; }
            set { this._selectedPerson = value; }
        }

        private bool _isOpen;
        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }

        public RelayCommand OpenCommand { get; set; }
        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        public void AddPerson()
        {
            Person person = new Person();
            People.Add(person);
            SelectedPerson = person;
        }

        public void DeletePerson()
        {
            Person person = new Person();
            person = SelectedPerson;
            People.Remove(person);
        }
    }

}
