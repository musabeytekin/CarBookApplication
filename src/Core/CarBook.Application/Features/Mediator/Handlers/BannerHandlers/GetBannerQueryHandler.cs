namespace CarBook.Application.Features.Mediator.Handlers.BannerHandlers;

public class GetBannerQueryHandler : IRequestHandler<GetBannerQuery, List<GetBannerQueryResult>>
{
    private readonly IRepository<Banner> _repository;

    public GetBannerQueryHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetBannerQueryResult>> Handle(GetBannerQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetAllAsync();
        return value.Select(x => new GetBannerQueryResult
        {
            BannerID = x.BannerID,
            Title = x.Title,
            Description = x.Description,
            VideoDescription = x.VideoDescription,
            VideoUrl = x.VideoUrl
        }).ToList();
    }
}