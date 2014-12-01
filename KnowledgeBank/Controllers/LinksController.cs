using KnowledgeBank.Lib.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnowledgeBank.Controllers
{
    public class LinksController : ApiController
    {
        private ILinkService service;
        public LinksController(ILinkService service)
        {
            this.service = service;
        }
        public List<string> GetAll()
        {
            return service.GetAll();
        }
    }
}
