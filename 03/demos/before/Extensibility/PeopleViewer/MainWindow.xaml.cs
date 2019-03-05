using PersonRepository.Factory;
using PersonRepository.Interface;
using System.Collections.Generic;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ServiceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateListBox("Service");
            //ClearListBox();
            //IEnumerable<Person> people = personRepository.GetPeople();
            //PersonListBox.ItemsSource = people;
            //ShowRepositoryType(personRepository);
        }

        private void CSVFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateListBox("CSV");
            //ClearListBox();
            //IEnumerable<Person> people = personRepository.GetPeople();
            //PersonListBox.ItemsSource = people;
            //ShowRepositoryType(personRepository);
        }

        private void SQLFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateListBox("SQL");
        }

        private void PopulateListBox(string repositoryType)
        {
            IPersonRepository personRepository = RepositoryFactory.GetPersonRepository(repositoryType); 
            ClearListBox();
            IEnumerable<Person> people = personRepository.GetPeople();
            PersonListBox.ItemsSource = people;
            ShowRepositoryType(personRepository);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            // PersonListBox.Items.Clear();
            PersonListBox.ItemsSource = null;

            RepositoryTypeTextBlock.Text = string.Empty;
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            RepositoryTypeTextBlock.Text = repository.GetType().ToString();
        }
    }
}
