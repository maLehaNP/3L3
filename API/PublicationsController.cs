using Domain.Abstract;
using Mappers;
using Models;
using Services.Abstract;
using System.Collections.Generic;

namespace API
{
    public class PublicationsController
    {
        private readonly IPublicationsService _driversService;

        public PublicationsController(IPublicationsService driversService)
        {
            _driversService = driversService;
        }


        public void AddDriver(PublicationModel model)
        {
            _driversService.AddPublication(model.ToDomain());
        }

        /*public PublicationModel GetDriverById(int id)
        {
            var publication = _driversService.GetPublicationById(id);
            if (publication == null) return null;

            return new PublicationModel
            {
                Name = publication.Name,
                Author = publication.Author,
            };
        }

        public void DeleteDriverById(int id)
        {
            _driversService.DeletePublicationById(id);
        }

        public List<PublicationModel> GetAllDrivers()
        {
            return _driversService.GetAllPublications().Select(x => x.ToModel()).ToList();
        }*/
    }
}
