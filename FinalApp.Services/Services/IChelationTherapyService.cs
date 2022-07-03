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
    public interface IChelationTherapyService
    {
        public Task<List<ChelationTherapyDto>> GetChelationTherapy();
        public Task<ChelationTherapyDto> GetChelationTherapyById(long id);

        public Task<long> CreateNewChelationTherapy(ChelationTherapyDto dto);

        public Task UpdateChelationTherapy(ChelationTherapyDto dto);

        public Task DeleteChelationTherapy(long id);
    }
}
