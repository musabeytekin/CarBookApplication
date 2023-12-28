namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;

public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
{
    private readonly IRepository<SocialMedia> _repository;

    public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }

    public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
    {
        var socialMedia = await _repository.GetByIdAsync(request.SocialMediaID);
        return new GetSocialMediaByIdQueryResult()
        {
            SocialMediaID = socialMedia.SocialMediaID,
            Name = socialMedia.Name,
            Url = socialMedia.Url,
            Icon = socialMedia.Icon
        };
    }
}