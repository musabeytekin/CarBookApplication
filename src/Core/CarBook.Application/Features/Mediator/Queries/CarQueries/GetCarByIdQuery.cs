namespace CarBook.Application.Features.Mediator.Queries.CarQueries;

public class GetCarByIdQuery : IRequest<List<GetCarQueryResult>>, IRequest<GetCarByIdQueryResult>
{
    public GetCarByIdQuery(int carId)
    {
        CarID = carId;
    }

    public int CarID { get; set; }
}