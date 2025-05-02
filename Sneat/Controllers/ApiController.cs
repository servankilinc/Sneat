using Microsoft.AspNetCore.Mvc;
using Sneat.Context;
using Sneat.Models;
using Sneat.Models.Datatable;

namespace Sneat.Controllers
{
    public class ApiController : Controller
    {
        [HttpPost]
        public DatatableResponseServerSide<TestModel> GetAllByPost(ExampleRequest datatableRequest)
        {
            var data = TestModelManager.List;
            var query  = data.AsQueryable();
            var responseModel = query.ToDatatableServerSide(datatableRequest.GetDatatableRequest());
            return responseModel;
        }

        [HttpGet]
        public DatatableResponseClientSide<TestModel> GetAllByGet(ExampleRequest request)
        {
            var data = TestModelManager.List; 
            var query = data.AsQueryable();
            var responseModel = query.ToDatatableClientSide();
            return responseModel;
        }
    }

    public class ExampleRequest: DatatableRequest
    {
        public string? UserName { get; set; }
        public string? LastName { get; set; }
    }
    public class ExampleRequest2
    {
        public string? userName { get; set; }
        public string? lastName { get; set; }
    }
}
