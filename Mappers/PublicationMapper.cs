using Domain;
using Entities;
using Models;

namespace Mappers
{
    public static class PublicationMapper
    {
        // Domain → Entity
        public static PublicationEntity ToEntity(this Publication publication)
        {
            return new PublicationEntity
            {
                //Id = 0, 
                Name = publication.Name,
                Author = publication.Author
            };
        }

        // Entity → Domain
        public static Publication ToDomain(this PublicationEntity entity)
        {
            if (entity == null) return null;

            return new Publication
            {
                Name = entity.Name,
                Author = entity.Author
            };
        }

        // Model → Domain
        public static Publication ToDomain(this PublicationModel model)
        {
            if (model == null) return null;

            return new Publication
            {
                Name = model.Name,
                Author = model.Author
            };
        }

        // Domain → Model
        public static PublicationModel ToModel(this Publication driver)
        {
            if (driver == null) return null;

            return new PublicationModel
            {
                Name = driver.Name,
                Author = driver.Author
            };
        }
    }
}