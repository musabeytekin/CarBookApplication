namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers;

public class DeleteSocialMediaCommandHandler : IRequestHandler<DeleteSocialMediaCommand>
{
    private readonly IRepository<SocialMedia> _repository;

    public DeleteSocialMediaCommandHandler(IRepository<SocialMedia> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteSocialMediaCommand request, CancellationToken cancellationToken)
    {
        var socialMedia = await _repository.GetByIdAsync(request.SocialMediaID);
        await _repository.DeleteAsync(socialMedia);
    }
}