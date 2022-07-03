using Microsoft.AspNetCore.Mvc;
using FinalApp.Entities;
using FinalApp.Services.Dto;
using FinalApp.Services.Services;

namespace FinalApp.Controllers
{
    [ApiController]
    [Route("Measurements")]
    public class MeasurementController : ControllerBase
    {
        private readonly IMeasurementService _service;
        public MeasurementController(IMeasurementService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<List<MeasurementDto>> GetMeasurements()
        {
            return _service.GetMeasurements();
        }

        [HttpGet("{id:long}")]
        public Task<MeasurementDto> GetById(long id)
        {
            return _service.GetMeasurementById(id);
        }

        [HttpPost]
        public Task<long> CreateNewMeasurement([FromBody] MeasurementDto dto)
        {
            return _service.CreateNewMeasurement(dto);
        }

        [HttpPut]
        public Task Update([FromBody] MeasurementDto dto)
        {
            return _service.UpdateMeasurement(dto);
        }

        [HttpDelete("{id:long}")]
        public Task Delete(long id)
        {
            return _service.DeleteMeasurement(id);
        }

    }
}
