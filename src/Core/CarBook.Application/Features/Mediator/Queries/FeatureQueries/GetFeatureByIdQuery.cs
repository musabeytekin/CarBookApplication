namespace CarBook.Application.Features.Mediator.Queries.FeatureQueries;

public class GetFeatureByIdQuery : IRequest<GetFeatureByIdQueryResult>
{
    public GetFeatureByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}