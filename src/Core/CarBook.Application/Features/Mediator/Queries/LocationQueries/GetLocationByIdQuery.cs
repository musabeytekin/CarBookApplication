namespace CarBook.Application.Features.Mediator.Queries.LocationQueries;

public class GetLocationByIdQuery : IRequest<GetLocationByIdQueryResult>
{
    public GetLocationByIdQuery(int locationId)
    {
        LocationID = locationId;
    }

    public int LocationID { get; set; }
}