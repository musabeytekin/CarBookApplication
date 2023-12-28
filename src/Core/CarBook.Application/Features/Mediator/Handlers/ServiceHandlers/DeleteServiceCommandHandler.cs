namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers;

public class DeleteServiceCommandHandler : IRequestHandler<DeleteServiceCommand>
{
    private readonly IRepository<Service> _repository;

    public DeleteServiceCommandHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteServiceCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.ServiceID);
        await _repository.DeleteAsync(value);
    }
}