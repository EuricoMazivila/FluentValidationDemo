using FluentValidationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FluentValidationDemo.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpPost]
        public IHttpActionResult AddCustomer(Customer customer)
        {
            CustomerValidator validator = new CustomerValidator();
            var result = validator.Validate(customer);

            if (!result.IsValid)
            {
                var allMessages = result.ToString("~");

                return BadRequest(allMessages);
            }

            return Ok(customer);
        }
    }
}
