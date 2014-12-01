using System;
namespace KnowledgeBank.Domain
{
    public interface IKBRespository
    {
        void Add(Link link);
        System.Collections.Generic.IEnumerable<Link> GetAll();
        Link GetByID(Guid id);
    }
}
