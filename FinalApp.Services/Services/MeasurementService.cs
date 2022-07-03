using FinalApp.DB;
using FinalApp.Entities;
using FinalApp.Services.Dto;
using FinalApp.Services.Mapper;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;


namespace FinalApp.Services.Services
{
    public class MeasurementService : IMeasurementService
    {
        private readonly AppDBContext _context;
        private readonly IMeasurementMapper _mapper;

        public MeasurementService(AppDBContext context, IMeasurementMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<List<MeasurementDto>> GetMeasurements()
        {
            return _context.Spectrometer_measurements.ProjectTo<MeasurementDto>(_mapper.ConfigurationProvider).ToListAsync();
        }
        public Task<MeasurementDto> GetMeasurementById(long id)
        {
            return _context.Spectrometer_measurements.ProjectTo<MeasurementDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<long> CreateNewMeasurement(MeasurementDto dto)
        {
            var entity = _mapper.Map<SpectrometerMeasurements>(dto);
            await _context.Spectrometer_measurements.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateMeasurement(MeasurementDto dto)
        {
            var entity = await _context.Spectrometer_measurements.FirstOrDefaultAsync(x => x.Id == dto.Id);

            if (entity is null)
            {
                throw new Exception($"Объект с id: {entity.Id} не найден");
            }
            _mapper.Map(dto, entity);


            await _context.SaveChangesAsync();
        }

        public async Task DeleteMeasurement(long id)
        {
            var entity = await _context.Spectrometer_measurements.FirstOrDefaultAsync(x => x.Id == id);
            _context.Spectrometer_measurements.Remove(entity);

            await _context.SaveChangesAsync();
        }

    }
}