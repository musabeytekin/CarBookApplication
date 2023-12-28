namespace CarBook.Application.Features.Mediator.Handlers.CarHandlers;

public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand>
{
    private readonly IRepository<Car> _repository;

    public CreateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateCarCommand request, CancellationToken cancellationToken)
    {
        var car = new Car
        {
            Model = request.Model,
            BrandID = request.BrandID,
            CoverImageUrl = request.CoverImageUrl,
            Km = request.Km,
            Transmission = request.Transmission,
            Seat = request.Seat,
            Fuel = request.Fuel,
            Luggage = request.Luggage,
            BigImageUrl = request.BigImageUrl
        };
        await _repository.CreateAsync(car);
    }
}