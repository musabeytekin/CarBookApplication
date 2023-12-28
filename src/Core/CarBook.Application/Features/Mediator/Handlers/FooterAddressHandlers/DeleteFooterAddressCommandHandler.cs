namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers;

public class DeleteFooterAddressCommandHandler : IRequestHandler<DeleteFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public DeleteFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteFooterAddressCommand request, CancellationToken cancellationToken)
    {
        var footerAddress = await _repository.GetByIdAsync(request.FooterAddressID);

        await _repository.DeleteAsync(footerAddress);
    }
}