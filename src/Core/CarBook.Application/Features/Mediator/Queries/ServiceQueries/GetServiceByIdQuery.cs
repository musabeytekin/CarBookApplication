namespace CarBook.Application.Features.Mediator.Queries.ServiceQueries;

public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
{
    public GetServiceByIdQuery(int serviceId)
    {
        ServiceID = serviceId;
    }

    public int ServiceID { get; set; }
}