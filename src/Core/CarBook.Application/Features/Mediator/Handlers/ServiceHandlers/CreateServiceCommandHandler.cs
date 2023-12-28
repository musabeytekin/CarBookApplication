namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers;

public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
{
    private readonly IRepository<Service> _repository;

    public CreateServiceCommandHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
    {
        var value = new Service
        {
            Title = request.Title,
            Description = request.Description,
            ImageUrl = request.ImageUrl
        };
        await _repository.CreateAsync(value);
    }
}