using Domain.Abstract;
using Data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Services
{
    class PublicationsService : IPublicationsService
    {
        private readonly IPublicationsRepository _publicationsRepository;

        public PublicationsService(IPublicationsRepository publicationsRepository)
        {
            _publicationsRepository = publicationsRepository;
        }

        public void AddPublication(Publication publication)
        {
            _publicationsRepository.AddPublication(publication);
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
