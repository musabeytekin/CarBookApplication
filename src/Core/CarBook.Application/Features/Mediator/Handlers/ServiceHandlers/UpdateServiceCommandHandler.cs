namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers;

public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
{
    private readonly IRepository<Service> _repository;

    public UpdateServiceCommandHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.ServiceID);
        value.Title = request.Title;
        value.Description = request.Description;
        value.ImageUrl = request.ImageUrl;
        await _repository.UpdateAsync(value);
    }
}