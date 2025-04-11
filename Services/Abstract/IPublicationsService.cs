using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract
{
    public interface IPublicationsService
    {
        void AddPublication(Publication publication);
        void UpdatePublication(Publication id);
        Publication GetPublicationById(int id);
        void DeletePublicationById(int id);

        List<Publication> GetAllPublications();
    }
}
