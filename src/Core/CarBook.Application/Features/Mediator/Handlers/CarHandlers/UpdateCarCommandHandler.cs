namespace CarBook.Application.Features.Mediator.Handlers.CarHandlers;

public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand>
{
    private readonly IRepository<Car> _repository;

    public UpdateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateCarCommand request, CancellationToken cancellationToken)
    {
        var car = await _repository.GetByIdAsync(request.CarID);
        car.BrandID = request.BrandID;
        car.Model = request.Model;
        car.CoverImageUrl = request.CoverImageUrl;
        car.Km = request.Km;
        car.Transmission = request.Transmission;
        car.Seat = request.Seat;
        car.Fuel = request.Fuel;
        car.Luggage = request.Luggage;
        car.BigImageUrl = request.BigImageUrl;
        await _repository.UpdateAsync(car);
    }
}