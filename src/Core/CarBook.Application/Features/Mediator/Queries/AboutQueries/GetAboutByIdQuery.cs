namespace CarBook.Application.Features.Mediator.Queries.AboutQueries;

public class GetAboutByIdQuery : IRequest<GetAboutByIdQueryResult>
{
    public GetAboutByIdQuery(int aboutId)
    {
        AboutID = aboutId;
    }

    public int AboutID { get; set; }
}