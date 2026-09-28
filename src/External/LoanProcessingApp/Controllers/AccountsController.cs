using LoanProcessingApp.Application.Contracts.CustomerInfo;
using LoanProcessingApp.Application.DTOs.Customer;
using Microsoft.AspNetCore.Mvc;

namespace LoanProcessingApp.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class AccountsController : ControllerBase
    {
        private readonly ILogger<AccountsController> _logger;
        private readonly ICustomerService _customerService;

        public AccountsController(ILogger<AccountsController> logger, ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpPost]
        [Route("register")]
        public Task Register([FromBody] PersonalInfoDto personalInfo, CancellationToken cancellationToken)
        {
            return _customerService.SaveCustomer(personalInfo, cancellationToken);
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
