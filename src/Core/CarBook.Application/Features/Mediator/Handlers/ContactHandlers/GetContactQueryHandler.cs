namespace CarBook.Application.Features.Mediator.Handlers.ContactHandlers;

public class GetContactQueryHandler : IRequestHandler<GetContactQuery, List<GetContactQueryResult>>
{
    private readonly IRepository<Contact> _repository;

    public GetContactQueryHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetContactQueryResult>> Handle(GetContactQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetContactQueryResult
        {
            ContactID = x.ContactID,
            Name = x.Name,
            Email = x.Email,
            Subject = x.Subject,
            Message = x.Message,
            SendDate = x.SendDate
        }).ToList();
    }
}