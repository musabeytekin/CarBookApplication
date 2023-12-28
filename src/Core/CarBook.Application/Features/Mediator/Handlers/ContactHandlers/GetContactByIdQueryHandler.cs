namespace CarBook.Application.Features.Mediator.Handlers.ContactHandlers;

public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQuery, GetContactByIdQueryResult>
{
    private readonly IRepository<Contact> _repository;

    public GetContactByIdQueryHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery request,
        CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.ContactID);
        return new GetContactByIdQueryResult
        {
            ContactID = value.ContactID,
            Name = value.Name,
            Email = value.Email,
            Subject = value.Subject,
            Message = value.Message,
            SendDate = value.SendDate
        };
    }
}