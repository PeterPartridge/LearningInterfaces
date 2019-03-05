using PersonRepository.Interface;
using System;
using System.Configuration;

namespace PersonRepository.Factory
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository()
        {
            string repositoryTypeName = ConfigurationManager.AppSettings["RepositoryType"];
            Type repositoryType = Type.GetType(repositoryTypeName);
            object repository = Activator.CreateInstance(repositoryType);
            // As tries to do a cast to a specific type, but is cast goes wrong it will return null.
            // if we cast using (IPersonRepository)repository will be more strict and throw an error.
           return repository as IPersonRepository;
        }
    }
}
