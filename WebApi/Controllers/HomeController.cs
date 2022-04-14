using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IBusinessService businessService;

        public HomeController(IBusinessService _businessService)
        {
            businessService = _businessService;
        }

        [HttpGet]
        public int Get()
        {
            return businessService.Get();
        }
    }
}
