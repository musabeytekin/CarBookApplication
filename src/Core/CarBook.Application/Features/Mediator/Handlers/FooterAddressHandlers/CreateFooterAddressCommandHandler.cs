namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers;

public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        var footerAddress = new FooterAddress
        {
            Description = request.Description,
            Address = request.Address,
            Phone = request.Phone,
            Email = request.Email
        };

        await _repository.CreateAsync(footerAddress);
    }
}