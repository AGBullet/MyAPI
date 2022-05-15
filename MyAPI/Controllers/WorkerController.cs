using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleAPI.Models;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/workers")]
    public class WorkerController
    {
        private readonly ILogger<WorkerController> _logger;

        public WorkerController(ILogger<WorkerController> logger)
        {
            _logger = logger;
        }

        List<Worker> workers = new List<Worker>
        {
            new() {Id = "1", Name = "Tom", Position = "Механик"},
            new() {Id = "2", Name = "Bob", Position = "Маляр"},
            new() {Id = "3", Name = "Sam", Position = "Рабочий"}
        };

        [HttpGet]
        public IEnumerable<Worker> Get()
        {
            return workers;
        }

        [HttpGet("{id}")]
        public Worker GetById(string id)
        {
            Worker? workers = this.workers.FirstOrDefault(u => u.Id == id);
            return workers;
        }
    }
}