namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;

public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
{
    private readonly IRepository<SocialMedia> _repository;

    public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
    {
        var socialMedias = await _repository.GetAllAsync();
        return socialMedias.Select(x => new GetSocialMediaQueryResult()
        {
            SocialMediaID = x.SocialMediaID,
            Name = x.Name,
            Url = x.Url,
            Icon = x.Icon
        }).ToList();
    }
}