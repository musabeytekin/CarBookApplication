namespace CarBook.Application.Features.Mediator.Handlers.CategoryHandlers;

public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
{
    private readonly IRepository<Category> _repository;

    public GetCategoryByIdQueryHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var category = await _repository.GetByIdAsync(request.CategoryID);
        return new GetCategoryByIdQueryResult { CategoryID = category.CategoryID, Name = category.Name };
    }
}