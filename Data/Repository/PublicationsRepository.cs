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
        private static int currentId = 1;

        public void AddPublication(PublicationEntity publication)
        {
            publication.Id = currentId++;
            publication.CreatedDate = DateTime.Now;
            list.Add(publication);
        }

        public void DeletePublicationById(int id)
        {
            var publication = list.FirstOrDefault(d => d.Id == id);
            if (publication != null)
            {
                list.Remove(publication);
            }
        }

        public void UpdatePublication(PublicationEntity updated)
        {
            var publication = list.FirstOrDefault(d => d.Id == updated.Id);
            if (publication != null)
            {
                publication.Name = updated.Name;
                publication.Author = updated.Author;
            }
        }

        public PublicationEntity GetPublicationById(int id)
        {
            return list.FirstOrDefault(d => d.Id == id);
        }

        public List<PublicationEntity> GetAllPublications()
        {
            return list;
        }
    }
}
