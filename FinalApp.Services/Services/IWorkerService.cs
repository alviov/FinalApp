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
    public interface IWorkerService
    {
        public Task<List<Worker>> GetWorkers();
        public Task<Worker> GetWorkerById(long id);

        public Task<long> CreateNewWorker(WorkerDto dto);

        public Task UpdateWorker(WorkerDto dto);

        public Task DeleteWorker(long id);
    }
}
