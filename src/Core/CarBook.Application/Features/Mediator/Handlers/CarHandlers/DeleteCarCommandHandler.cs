namespace CarBook.Application.Features.Mediator.Handlers.CarHandlers;

public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand>
{
    private readonly IRepository<Car> _repository;

    public DeleteCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteCarCommand request, CancellationToken cancellationToken)
    {
        var car = await _repository.GetByIdAsync(request.CarID);
        await _repository.DeleteAsync(car);
    }
}