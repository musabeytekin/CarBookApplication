namespace CarBook.Application.Features.Mediator.Handlers.PricingHandlers;

public class DeletePricingCommandHandler : IRequestHandler<DeletePricingCommand>
{
    private readonly IRepository<Pricing> _repository;

    public DeletePricingCommandHandler(IRepository<Pricing> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeletePricingCommand request, CancellationToken cancellationToken)
    {
        var pricing = await _repository.GetByIdAsync(request.PricingID);
        await _repository.DeleteAsync(pricing);
    }
}