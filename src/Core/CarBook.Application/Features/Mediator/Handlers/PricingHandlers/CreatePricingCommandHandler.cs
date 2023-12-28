namespace CarBook.Application.Features.Mediator.Handlers.PricingHandlers;

public class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommand>
{
    private readonly IRepository<Pricing> _repository;

    public CreatePricingCommandHandler(IRepository<Pricing> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreatePricingCommand request, CancellationToken cancellationToken)
    {
        var pricing = new Pricing
        {
            Name = request.Name
        };

        await _repository.CreateAsync(pricing);
    }
}