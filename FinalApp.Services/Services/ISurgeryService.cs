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
    public interface ISurgeryService
    {
        public Task<List<SurgeryDto>> GetSurgery();
        public Task<SurgeryDto> GetSurgeryById(long id);

        public Task<long> CreateNewSurgery(SurgeryDto dto);

        public Task UpdateSurgery(SurgeryDto dto);

        public Task DeleteSurgery(long id);
    }
}
