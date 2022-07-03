using Microsoft.AspNetCore.Mvc;
using FinalApp.Entities;
using FinalApp.Services.Dto;
using FinalApp.Services.Services;
using FinalApp.Services.Services;

namespace FinalApp.Controllers
{
    [ApiController]
    [Route("Workplaces")]
    public class WorkplacesController : ControllerBase
    {
        private readonly IWorkplaceService _service;
        public WorkplacesController(IWorkplaceService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<List<Workplace>> GetWorkplaces()
        {
            return _service.GetWorkplaces();
        }

        [HttpGet("{id:long}")]
        public Task<Workplace> GetWorkplaceById(long id)
        {
            return _service.GetWorkplaceById(id);
        }

        [HttpPost]
        public Task<long> CreateNewWorkplace([FromBody] Workplace wpl)
        {
            return _service.CreateNewWorkplace(wpl);
        }

        [HttpPut]
        public Task UpdateWorkplace([FromBody] Workplace wpl)
        {
            return _service.UpdateWorkplace(wpl);
        }

        [HttpDelete("{id:long}")]
        public Task DeleteWorkplace(long id)
        {
            return _service.DeleteWorkplace(id);
        }

    }
}
