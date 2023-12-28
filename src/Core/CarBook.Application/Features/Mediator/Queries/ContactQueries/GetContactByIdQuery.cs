namespace CarBook.Application.Features.Mediator.Queries.ContactQueries;

public class GetContactByIdQuery : IRequest<GetContactByIdQueryResult>
{
    public GetContactByIdQuery(int contactId)
    {
        ContactID = contactId;
    }

    public int ContactID { get; set; }
}