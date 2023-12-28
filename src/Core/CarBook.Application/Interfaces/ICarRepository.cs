namespace CarBook.Application.Interfaces;

public interface ICarRepository
{
    Task<List<Car>> GetCarsWithBrandsAsync();
}