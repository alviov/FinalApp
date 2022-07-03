using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalApp.DB;
using FinalApp.Entities;
using FinalApp.Services.Dto;

namespace FinalApp.Services.Services
{
    public interface IMeasurementService
    {
        public Task<List<MeasurementDto>> GetMeasurements();
        public Task<MeasurementDto> GetMeasurementById(long id);

        public Task<long> CreateNewMeasurement(MeasurementDto dto);

        public Task UpdateMeasurement(MeasurementDto dto);

        public Task DeleteMeasurement(long id);
    }
}
