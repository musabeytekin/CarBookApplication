using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.CarRepositories;

public class CarRepository : ICarRepository
{
    private readonly CarBookContext _context;

    public CarRepository(CarBookContext context)
    {
        _context = context;
    }

    public async Task<List<Car>> GetCarsWithBrandsAsync()
    {
        return await _context.Cars.Include(x => x.Brand).ToListAsync();
    }
}