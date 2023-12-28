namespace CarBook.Application.Features.Mediator.Handlers.ContactHandlers;

public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand>
{
    private readonly IRepository<Contact> _repository;

    public DeleteContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteContactCommand request, CancellationToken cancellationToken)
    {
        var contact = await _repository.GetByIdAsync(request.ContactID);
        await _repository.DeleteAsync(contact);
    }
} 