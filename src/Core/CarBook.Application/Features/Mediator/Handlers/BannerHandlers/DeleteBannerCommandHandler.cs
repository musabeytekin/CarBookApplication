namespace CarBook.Application.Features.Mediator.Handlers.BannerHandlers;

public class DeleteBannerCommandHandler : IRequestHandler<DeleteBannerCommand>
{
    private readonly IRepository<Banner> _repository;

    public DeleteBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteBannerCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.BannerID);
        await _repository.DeleteAsync(value);
    }
}