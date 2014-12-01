using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBank.Domain
{
    public class KBRespository:AbstractRepository, KnowledgeBank.Domain.IKBRespository
    {
        public IEnumerable<Link> GetAll()
        {
            return context.Links;
        }
        public Link GetByID(Guid id)
        {
            return context.Links.FirstOrDefault(p => p.ID == id);
        }

        public void Add(Link link)
        {
            context.Links.Add(link);
            context.SaveChanges();
        }
    }
}
