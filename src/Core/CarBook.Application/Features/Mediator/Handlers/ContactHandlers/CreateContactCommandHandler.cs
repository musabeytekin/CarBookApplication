namespace CarBook.Application.Features.Mediator.Handlers.ContactHandlers;

public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand>
{
    private readonly IRepository<Contact> _repository;

    public CreateContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
    {
        var value = new Contact
        {
            Name = request.Name,
            Email = request.Email,
            Subject = request.Subject,
            Message = request.Message,
            SendDate = DateTime.Now
        };
        await _repository.CreateAsync(value);
    }
}