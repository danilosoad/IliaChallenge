using ApiRestFul.Application.Interfaces;
using ApiRestFul.Domain.Entities;
using ApiRestFul.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ApiRestFul.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IUnityOfWork _unityOfWork;
        private readonly IApiAppService _apiAppService;

        public CustomerController(ICustomerRepository customerRepo, IUnityOfWork unityOfWork, IApiAppService apiAppService)
        {
            _customerRepo = customerRepo;
            _unityOfWork = unityOfWork;
            _apiAppService = apiAppService;
        }
        [HttpGet]
        public dynamic Get()
        {
            return _apiAppService.GetCustomers();
        }

        [HttpGet]
        [Route("{id}")]
        public dynamic Get(int id)
        {
            return _apiAppService.GetCustomersById(id);
        }

        [HttpPost]
        public dynamic Post([FromBody] Customer customer)
        {
            try
            {
                _apiAppService.AddCustomer(customer);
                return Ok();
            }
            catch (Exception e)
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        [HttpPut]
        public dynamic Update([FromBody] Customer customer)
        {
            try
            {
                _apiAppService.UpdateCustomer(customer);
                return Ok();
            }
            catch (Exception e)
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public dynamic Delete(int id)
        {
            try
            {
                _apiAppService.DeleteCustomer(id);
                return Ok();
            }
            catch (Exception)
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
