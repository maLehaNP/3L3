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
        /*public static Driver ToDomain(this DriverEntity entity)
        {
            if (entity == null) return null;

            return new Driver
            {
                Name = entity.Name,
                Age = entity.Age,
                Vehicles = new List<Vehicle>()
            };
        }*/

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
        /*public static DriverModel ToModel(this Driver driver)
        {
            if (driver == null) return null;

            return new DriverModel
            {
                Name = driver.Name,
                Age = driver.Age,
                Vehicles = driver.Vehicles?.Select(v => v.ToModel()).ToList() ?? new List<VehicleModel>()
            };
        }*/
    }
}