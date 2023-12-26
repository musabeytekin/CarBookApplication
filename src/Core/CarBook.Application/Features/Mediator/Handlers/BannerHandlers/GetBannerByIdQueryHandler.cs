namespace CarBook.Application.Features.Mediator.Handlers.BannerHandlers;

public class GetBannerByIdQueryHandler : IRequestHandler<GetBannerByIdQuery, GetBannerByIdQueryResult>
{
    private readonly IRepository<Banner> _repository;

    public GetBannerByIdQueryHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.BannerID);
        return new GetBannerByIdQueryResult
        {
            BannerID = value.BannerID,
            Title = value.Title,
            Description = value.Description,
            VideoDescription = value.VideoDescription,
            VideoUrl = value.VideoUrl
        };   
    }
}