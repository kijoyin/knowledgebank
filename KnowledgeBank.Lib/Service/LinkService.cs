using KnowledgeBank.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBank.Lib.Service
{
    public class LinkService:IService, ILinkService
    {
        private IKBRespository repository;
        public LinkService(IKBRespository repository)
        {
            this.repository = repository;
        }
        public List<string> GetAll()
        {
            var test = repository.GetAll();
            return new List<string>() { "test", "sdfsd" };
        }
    }
}
