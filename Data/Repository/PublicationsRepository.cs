using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repository.Abstract;
using Entities;

namespace Data.Repository
{
    class PublicationsRepository : IPublicationsRepository
    {
        private static List<PublicationEntity> list = new List<PublicationEntity>();

        public void AddPublication(PublicationEntity publication)
        {
            throw new NotImplementedException();
        }

        public void DeletePublicationById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PublicationEntity> GetAllPublications()
        {
            throw new NotImplementedException();
        }

        public PublicationEntity GetPublicationById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePublication(PublicationEntity id)
        {
            throw new NotImplementedException();
        }
    }
}
