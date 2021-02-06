using System.Collections.Generic;
using System.Web.Http;
using TestApplication.Entities;

namespace TestApplication.Controllers
{
    /// <summary>
    /// Controller showing DI example
    /// </summary>
    public class ProductController : ApiController
    {
        readonly IProductRepository repository;

        //inject dependency
        public ProductController(IProductRepository repository)  // here IProductRepository will be injected from while app is started, that will call Bootstrapper.Run method
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Product> Index()
        {
            var data = repository.GetAll();
            return data;
        }
    }
}
