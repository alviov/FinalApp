using FinalApp.DB;
using FinalApp.Entities;
using FinalApp.Services.Dto;
using FinalApp.Services.Mapper;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;


namespace FinalApp.Services.Services
{
    public class SurgeryService : ISurgeryService
    {
        private readonly AppDBContext _context;
        private readonly ISurgeryMapper _mapper;

        public SurgeryService(AppDBContext context, ISurgeryMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<List<SurgeryDto>> GetSurgery()
        {
            return _context.SurgeryData.ProjectTo<SurgeryDto>(_mapper.ConfigurationProvider).ToListAsync();
        }
        public Task<SurgeryDto> GetSurgeryById(long id)
        {
            return _context.SurgeryData.ProjectTo<SurgeryDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<long> CreateNewSurgery(SurgeryDto dto)
        {
            var entity = _mapper.Map<SurgeryData>(dto);
            await _context.SurgeryData.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateSurgery(SurgeryDto dto)
        {
            var entity = await _context.SurgeryData.FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (entity is null)
            {
                throw new Exception($"Объект с id: {entity.Id} не найден");
            }
            _mapper.Map(dto, entity);


            await _context.SaveChangesAsync();
        }

        public async Task DeleteSurgery(long id)
        {
            var entity = await _context.SurgeryData.FirstOrDefaultAsync(x => x.Id == id);
            _context.SurgeryData.Remove(entity);

            await _context.SaveChangesAsync();
        }

    }
}