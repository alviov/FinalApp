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
    public interface IWorkplaceService
    {
        public Task<List<Workplace>> GetWorkplaces();
        public Task<Workplace> GetWorkplaceById(long id);

        public Task<long> CreateNewWorkplace(Workplace wpl);

        public Task UpdateWorkplace(Workplace wpl);

        public Task DeleteWorkplace(long id);
    }
}
