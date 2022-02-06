using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RIMOTECH.Models;
using RIMOTECH.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RIMOTECH.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerservice _customerservice;

        public CustomerController(
            ICustomerservice customerservice)
        {
            _customerservice = customerservice;
        }
        [HttpPost("PostCustomer")]
        public async Task<IActionResult> PostCustomer([FromBody] Customer model)
        {
            await _customerservice.RegisterAsync(model);
            return Ok(new { message = "New Customer Registration successful" });
        }

        [HttpGet("GetCustomer/{Id:int}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customer = await _customerservice.Getcustomerasync(id);
            return Ok(customer);
        }
        [HttpGet("GetCustomers")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            var customers = await _customerservice.GetCustomersAsyn();
            return Ok(customers);
        }

        [HttpGet("GetCustomersbystoreid/{storeid:int}")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomersbystoreid(int storeid)
        {
            var customers = await _customerservice.GetcustomerbystoreAsync(storeid);
            return Ok(customers);
        }
    }
}
