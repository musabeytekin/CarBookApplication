namespace CarBook.Application.Features.Mediator.Handlers.ContactHandlers;

public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand>
{
    private readonly IRepository<Contact> _repository;

    public UpdateContactCommandHandler(IRepository<Contact> contactRepository)
    {
        _repository = contactRepository;
    }

    public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
    {
        var contact = await _repository.GetByIdAsync(request.ContactID);

        contact.Name = request.Name;
        contact.Email = request.Email;
        contact.Subject = request.Subject;
        contact.Message = request.Message;
        await _repository.UpdateAsync(contact);
    }
}
