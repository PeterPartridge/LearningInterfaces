using NUnit.Framework;
using System.Linq;

namespace PeopleViewer.Test
{
    public class PeopleViewModelTest
    {
        [Test]
        public void People_OnFetchData_IsPopulated()
        {
            //Arrange
            PeopleViewModel peopleViewModel = new PeopleViewModel();

            //Act
            peopleViewModel.FetchData();

            //Assert
            Assert.IsNotNull(peopleViewModel.People);
            Assert.AreEqual(2, peopleViewModel.People.Count());
        }
        [Test]
        public void RepositoryType_OnCreation_ReturnsFakeRepositoryString()
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            string expectedString = "PersonRepository.Fake.FakeRepository";

            Assert.AreEqual(expectedString, peopleViewModel.RepositoryType);
        }
    }
}
