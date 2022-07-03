using FinalApp.DB;
using FinalApp.Entities;
using FinalApp.Services.Dto;
using FinalApp.Services.Mapper;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;


namespace FinalApp.Services.Services
{
    public class ChelationTherapyService : IChelationTherapyService
    {
        private readonly AppDBContext _context;
        private readonly IChelationTherapyMapper _mapper;

        public ChelationTherapyService(AppDBContext context, IChelationTherapyMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<List<ChelationTherapyDto>> GetChelationTherapy()
        {
            return _context.Chelation_therapyData.ProjectTo<ChelationTherapyDto>(_mapper.ConfigurationProvider).ToListAsync();
        }
        public Task<ChelationTherapyDto> GetChelationTherapyById(long id)
        {
            return _context.Chelation_therapyData.ProjectTo<ChelationTherapyDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<long> CreateNewChelationTherapy(ChelationTherapyDto dto)
        {
            var entity = _mapper.Map<ChelationTherapyData>(dto);
            await _context.Chelation_therapyData.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateChelationTherapy(ChelationTherapyDto dto)
        {
            var entity = await _context.Chelation_therapyData.FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (entity is null)
            {
                throw new Exception($"Объект с id: {entity.Id} не найден");
            }
            _mapper.Map(dto, entity);


            await _context.SaveChangesAsync();
        }

        public async Task DeleteChelationTherapy(long id)
        {
            var entity = await _context.Chelation_therapyData.FirstOrDefaultAsync(x => x.Id == id);
            _context.Chelation_therapyData.Remove(entity);

            await _context.SaveChangesAsync();
        }

    }
}