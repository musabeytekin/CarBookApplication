
namespace CarBook.Application.Features.Mediator.Handlers.BannerHandlers;

public class CreateBannerCommandHandler : IRequestHandler<CreateBannerCommand>
{

    private readonly IRepository<Banner> _repository;

    public CreateBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateBannerCommand request, CancellationToken cancellationToken)
    {
        var value = new Banner
        {
            Title = request.Title,
            Description = request.Description,
            VideoDescription = request.VideoDescription,
            VideoUrl = request.VideoUrl
        };

        await _repository.CreateAsync(value);
    }
}