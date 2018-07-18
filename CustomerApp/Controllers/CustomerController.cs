namespace CustomerApp.Controllers
{
    using CustomerApp.Models;
    using CustomerApp.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpPost]
        public IActionResult Search([FromBody] CustomerSearchRequestApiModel request)
        {
            var searchResult = customerService.Search(request.SearchTerm, request.PageSize, request.PageNumber);
            return Ok(searchResult);
        }
    }
}