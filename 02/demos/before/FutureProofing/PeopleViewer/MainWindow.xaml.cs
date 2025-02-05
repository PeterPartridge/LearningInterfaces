﻿using Common;
using People.Library;
using System.Collections.Generic;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        PersonRepository repository = new PersonRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            // Person[] people = repository.GetPeople();
            // The change from array to list has broken the code.
            List<Person> people = repository.GetPeople();
            PersonListBox.ItemsSource = people;
            //foreach (var person in people)
            //{
            //    PersonListBox.Items.Add(person);
            //}
        }

        private void AbstractFetchButton_Click(object sender, RoutedEventArgs e)
        {
            //This is more flexible and future proofed as long as IEnumerable or children are used.
            IEnumerable<Person> people = repository.GetPeople();
            PersonListBox.ItemsSource = people;
            //foreach (var person in people)
            //{
            //    PersonListBox.Items.Add(person);
            //}
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.ItemsSource = null;
        }
    }
}
