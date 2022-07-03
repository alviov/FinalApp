using Microsoft.AspNetCore.Mvc;
using FinalApp.Entities;
using FinalApp.Services.Dto;
using FinalApp.Services.Services;
using FinalApp.Services.Services;

namespace FinalApp.Controllers
{
    [ApiController]
    [Route("Workers")]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _service;
        public WorkerController(IWorkerService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<List<Worker>> GetWorkers()
        {
            return _service.GetWorkers();
        }

        [HttpGet("{id:long}")]
        public Task<Worker> GetById(long id)
        {
            return _service.GetWorkerById(id);
        }

        [HttpPost]
        public Task<long> CreateNewWorker([FromBody] WorkerDto dto)
        {
            return _service.CreateNewWorker(dto);
        }

        [HttpPut]
        public Task UpdateWorker([FromBody] WorkerDto dto)
        {
            return _service.UpdateWorker(dto);
        }

        [HttpDelete("{id:long}")]
        public Task DeleteWorker(long id)
        {
            return _service.DeleteWorker(id);
        }

    }
}
