using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data.Repository.Abstract
{
    public interface IPublicationsRepository
    {
        void AddPublication(PublicationEntity publication);
        void UpdatePublication(PublicationEntity id);
        PublicationEntity GetPublicationById(int id);
        void DeletePublicationById(int id);

        List<PublicationEntity> GetAllPublications();
    }
}
