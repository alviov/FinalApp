using Microsoft.AspNetCore.Mvc;
using FinalApp.Entities;
using FinalApp.Services.Dto;
using FinalApp.Services.Services;
using FinalApp.Services.Services;

namespace FinalApp.Controllers
{
    [ApiController]
    [Route("Surgery")]
    public class SurgeryController : ControllerBase
    {
        private readonly ISurgeryService _service;
        public SurgeryController(ISurgeryService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<List<SurgeryDto>> GetSurgery()
        {
            return _service.GetSurgery();
        }

        [HttpGet("{id:long}")]
        public Task<SurgeryDto> GetSurgeryById(long id)
        {
            return _service.GetSurgeryById(id);
        }

        [HttpPost]
        public Task<long> CreateNewSurgery([FromBody] SurgeryDto dto)
        {
            return _service.CreateNewSurgery(dto);
        }

        [HttpPut]
        public Task UpdateSurgery([FromBody] SurgeryDto dto)
        {
            return _service.UpdateSurgery(dto);
        }

        [HttpDelete("{id:long}")]
        public Task DeleteSurgery(long id)
        {
            return _service.DeleteSurgery(id);
        }

    }
}
