using FinalApp.DB;
using FinalApp.Entities;
using FinalApp.Services.Dto;
using FinalApp.Services.Services;
using FinalApp.Services.Mapper;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;


namespace FinalApp.Services.Services
{
    public class WorkplaceService : IWorkplaceService
    {
        private readonly AppDBContext _context;


        public WorkplaceService(AppDBContext context)
        {
            _context = context;
        }
        public Task<List<Workplace>> GetWorkplaces()
        {
            return _context.Workplaces.ToListAsync();
        }
        public Task<Workplace> GetWorkplaceById(long id)
        {
            return _context.Workplaces.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<long> CreateNewWorkplace(Workplace wpl)
        {
            await _context.Workplaces.AddAsync(wpl);
            await _context.SaveChangesAsync();

            return wpl.Id;
        }

        public async Task UpdateWorkplace(Workplace wpl)
        {
            var entity = await _context.Workplaces.FirstOrDefaultAsync(x => x.Id == wpl.Id);

            if (entity is null)
            {
                throw new Exception($"Объект с id: {entity.Id} не найден");
            }
            await _context.SaveChangesAsync();
        }

        public async Task DeleteWorkplace(long id)
        {
            var entity = await _context.Workplaces.FirstOrDefaultAsync(x => x.Id == id);
            _context.Workplaces.Remove(entity);

            await _context.SaveChangesAsync();
        }

    }
}