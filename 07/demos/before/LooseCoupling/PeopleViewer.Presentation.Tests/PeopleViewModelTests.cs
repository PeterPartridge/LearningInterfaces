using Common;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleViewer.Presentation.Tests
{
    public class PeopleViewModelTests
    {
        private IPersonRepository GetTestPersonRepository()
        {
            return new FakeRepository();
        }

        [Test]
        public void RefreshPeople_OnExecute_PeopleIsPopulated()
        {
            // Arrange
            IPersonRepository fakeRepository = GetTestPersonRepository();
            PeopleViewModel peopleViewModel = new PeopleViewModel( fakeRepository);
            // Act
            peopleViewModel.RefreshPeople();
            // Assert
            Assert.IsNotNull(peopleViewModel.People);
            Assert.AreEqual(2, peopleViewModel.People.Count());
        }

        [Test]
        public void ClearPeople_OnExecute_PeopleIsEmpty()
        {
            // Arrange
            var repository = GetTestPersonRepository();
            var vm = new PeopleViewModel(repository);
            vm.RefreshPeople();
            Assert.AreEqual(2, vm.People.Count(), "Invalid Arrangement");

            // Act
            vm.ClearPeople();

            // Assert
            Assert.AreEqual(0, vm.People.Count());
        }
    }
}
