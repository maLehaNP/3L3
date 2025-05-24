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
            _publicationsRepository.AddPublication(publication.ToEntity());
        }

        public void DeletePublicationById(int id)
        {
            _publicationsRepository.DeletePublicationById(id);
        }

        public List<Publication> GetAllPublications()
        {
            var entities = _publicationsRepository.GetAllPublications();
            return entities.Select(x => x.ToDomain()).ToList();
        }

        public Publication GetPublicationById(int id)
        {
            var entity = _publicationsRepository.GetPublicationById(id);
            if (entity == null) return null;

            return new Publication
            {
                Name = entity.Name,
                Author = entity.Author
            };
        }

        public void UpdatePublication(Publication publication)
        {
            _publicationsRepository.UpdatePublication(publication.ToEntity());
        }
    }
}
