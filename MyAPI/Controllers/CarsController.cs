using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleAPI.Models;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }
        
        List<Cars> cars = new List<Cars>
        {
            new() { Id = "1", Name = "Toyota", Number= "A111AA790" },
            new() { Id = "2", Name = "BMW", Number= "B222BB790" },
            new() { Id = "3", Name = "Audi", Number= "C333CC790"  }
        };
        [HttpGet]
        public IEnumerable<Cars> Get()
        {
            return cars;
        }
        [HttpGet("{id}")]
        public Cars GetById(string id)
        {
            Cars? car = cars.FirstOrDefault(u => u.Id == id);
            return car;
        }
    }
}