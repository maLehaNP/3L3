using Domain.Abstract;
using Data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class PublicationsService : IPublicationsService
    {
        private readonly IPublicationsRepository _publicationsRepository;

        public void AddPublication(Publication publication)
        {
            throw new NotImplementedException();
        }

        public void DeletePublicationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Publication> GetAllPublications()
        {
            throw new NotImplementedException();
        }

        public Publication GetPublicationById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePublication(Publication id)
        {
            throw new NotImplementedException();
        }
    }
}
