using FinalApp.DB;
using FinalApp.Entities;
using FinalApp.Services.Dto;
using FinalApp.Services.Services;
using FinalApp.Services.Mapper;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;


namespace FinalApp.Services.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly AppDBContext _context;
        private readonly IWorkerMapper _mapper;


        public WorkerService(AppDBContext context, IWorkerMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<List<Worker>> GetWorkers()
        {
            return _context.Workers.ToListAsync();
        }
        public Task<Worker> GetWorkerById(long id)
        {
            return _context.Workers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<long> CreateNewWorker(WorkerDto dto)
        {
            var entity = _mapper.Map<Worker>(dto);
            await _context.Workers.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateWorker(WorkerDto dto)
        {
            var entity = await _context.Workers.FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (entity is null)
            {
                throw new Exception($"Объект с id: {entity.Id} не найден");
            }
            _mapper.Map(dto, entity);


            await _context.SaveChangesAsync();
        }

        public async Task DeleteWorker(long id)
        {
            var entity = await _context.Workers.FirstOrDefaultAsync(x => x.Id == id);
            _context.Workers.Remove(entity);

            await _context.SaveChangesAsync();
        }

    }
}