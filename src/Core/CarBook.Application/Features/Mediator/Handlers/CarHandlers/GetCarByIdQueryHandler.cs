namespace CarBook.Application.Features.Mediator.Handlers.CarHandlers;

public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, GetCarByIdQueryResult>
{
    private readonly IRepository<Car> _repository;

    public GetCarByIdQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.CarID);
        return new GetCarByIdQueryResult()
        {
            CarID = value.CarID,
            BrandID = value.BrandID,
            Model = value.Model,
            CoverImageUrl = value.CoverImageUrl,
            Km = value.Km,
            Transmission = value.Transmission,
            Seat = value.Seat,
            Fuel = value.Fuel,
            Luggage = value.Luggage,
            BigImageUrl = value.BigImageUrl
        };
    }
}