﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;                       // Gelenin referansı _productService'e atanmış oldu.
        }

        [HttpGet("getallcustomer")]
        public IActionResult GetAll()
        {
            //Dependency chain -- 

            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);      //Ok 200
            }
            return BadRequest(result);
        }

        [HttpGet("getbyidcustomer")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpPost("addcustomer")]       // add - update - delete
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
