using CarBook.Application.Features.Mediator.Commands.AboutCommands;

namespace CarBook.Application.Features.Mediator.Handlers.BannerHandlers;

public class UpdateBannerCommandHandler : IRequestHandler<UpdateBannerCommand>
{
    private readonly IRepository<Banner> _repository;

    public UpdateBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBannerCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.BannerID);
        value.Title = request.Title;
        value.Description = request.Description;
        value.VideoDescription = request.VideoDescription;
        value.VideoUrl = request.VideoUrl;
        await _repository.UpdateAsync(value);
    }
}