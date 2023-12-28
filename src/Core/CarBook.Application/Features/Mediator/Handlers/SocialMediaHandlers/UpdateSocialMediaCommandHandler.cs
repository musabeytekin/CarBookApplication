namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;

public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
{
    private readonly IRepository<SocialMedia> _repository;

    public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        
        var socialMedia = await _repository.GetByIdAsync(request.SocialMediaID);
        socialMedia.Name = request.Name;
        socialMedia.Url = request.Url;
        socialMedia.Icon = request.Icon;
        await _repository.UpdateAsync(socialMedia);
    }
}