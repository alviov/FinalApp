using Microsoft.AspNetCore.Mvc;
using FinalApp.Entities;
using FinalApp.Services.Dto;
using FinalApp.Services.Services;
using FinalApp.Services.Services;

namespace FinalApp.Controllers
{
    [ApiController]
    [Route("Данные о введении хелатов")]
    public class ChelationTherapyController : ControllerBase
    {
        private readonly IChelationTherapyService _service;
        public ChelationTherapyController(IChelationTherapyService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<List<ChelationTherapyDto>> GetChelationTherapy()
        {
            return _service.GetChelationTherapy();
        }

        [HttpGet("{id:long}")]
        public Task<ChelationTherapyDto> GetChelationTherapyById(long id)
        {
            return _service.GetChelationTherapyById(id);
        }

        [HttpPost]
        public Task<long> CreateNewChelationTherapy([FromBody] ChelationTherapyDto dto)
        {
            return _service.CreateNewChelationTherapy(dto);
        }

        [HttpPut]
        public Task UpdateChelationTherapy([FromBody] ChelationTherapyDto dto)
        {
            return _service.UpdateChelationTherapy(dto);
        }

        [HttpDelete("{id:long}")]
        public Task DeleteChelationTherapy(long id)
        {
            return _service.DeleteChelationTherapy(id);
        }

    }
}
