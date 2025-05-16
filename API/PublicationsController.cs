using Domain.Abstract;
using Mappers;
using Models;
using Services;
using System.Collections.Generic;

namespace API
{
    public class PublicationsController
    {
        private readonly IPublicationsService _publicationsService;

        public PublicationsController(IPublicationsService publicationsService)
        {
            _publicationsService = publicationsService;
        }


        public void AddPublication(PublicationModel model)
        {
            _publicationsService.AddPublication(model.ToDomain());
        }

        public PublicationModel GetPublicationById(int id)
        {
            var publication = _publicationsService.GetPublicationById(id);
            if (publication == null) return null;

            return new PublicationModel
            {
                Name = publication.Name,
                Author = publication.Author,
            };
        }

        public void DeletePublicationById(int id)
        {
            _publicationsService.DeletePublicationById(id);
        }

        public List<PublicationModel> GetAllPublications()
        {
            return _publicationsService.GetAllPublications().Select(x => x.ToModel()).ToList();
        }
    }
}
