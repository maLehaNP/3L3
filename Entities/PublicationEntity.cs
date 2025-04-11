using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities
{
    public abstract class PublicationEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
