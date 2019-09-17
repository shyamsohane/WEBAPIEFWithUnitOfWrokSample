using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Threenine.Data;
using WebAPIPOCWithEF.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIPOCWithEF.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {

        private readonly IUnitOfWork _UOW;
        public ProductController(IUnitOfWork uow)
        {
            _UOW = uow;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            var repo = _UOW.GetReadOnlyRepository<Product>();
            return repo.GetList().Items.ToList();
        }
    }
}
