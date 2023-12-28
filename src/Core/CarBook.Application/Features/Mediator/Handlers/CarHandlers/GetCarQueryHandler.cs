namespace CarBook.Application.Features.Mediator.Handlers.CarHandlers;

public class GetCarQueryHandler : IRequestHandler<GetCarQuery, List<GetCarQueryResult>>
{
    private readonly ICarRepository _carRepository;

    public GetCarQueryHandler(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public async Task<List<GetCarQueryResult>> Handle(GetCarQuery request, CancellationToken cancellationToken)
    {
        var cars = await _carRepository.GetCarsWithBrandsAsync();
        return cars.Select(x => new GetCarQueryResult
        {
            CarID = x.CarID,
            BrandName = x.Brand.Name,
            Fuel = x.Fuel,
            Km = x.Km,
            Luggage = x.Luggage,
            Model = x.Model,
            Transmission = x.Transmission,
            BigImageUrl = x.BigImageUrl,
            CoverImageUrl = x.CoverImageUrl,
            Seat = x.Seat
        }).ToList();
    }
}