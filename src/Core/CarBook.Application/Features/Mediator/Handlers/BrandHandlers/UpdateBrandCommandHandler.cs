namespace CarBook.Application.Features.Mediator.Handlers.BrandHandlers;

public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand>
{

    private readonly IRepository<Brand> _repository;

    public UpdateBrandCommandHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.BrandID);
        value.Name = request.Name;
        await _repository.UpdateAsync(value);
    }
}