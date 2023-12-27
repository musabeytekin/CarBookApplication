
namespace CarBook.Application.Features.Mediator.Handlers.BrandHandlers;

public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommand>
{
    private readonly IRepository<Brand> _repository;

    public DeleteBrandCommandHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.BrandID);
        await _repository.DeleteAsync(value);
    }
}