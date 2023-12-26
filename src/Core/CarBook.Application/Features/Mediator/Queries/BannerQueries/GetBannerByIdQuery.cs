namespace CarBook.Application.Features.Mediator.Queries.BannerQueries;

public class GetBannerByIdQuery : IRequest<GetBannerByIdQueryResult>
{
    public GetBannerByIdQuery(int bannerId)
    {
        BannerID = bannerId;
    }

    public int BannerID { get; set; }
   
}