namespace CarBook.Application.Features.Mediator.Handlers.CategoryHandlers;

public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
{
    private readonly IRepository<Category> _repository;

    public GetCategoryQueryHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request,
        CancellationToken cancellationToken)
    {
        var categories = await _repository.GetAllAsync();
        return categories.Select(x => new GetCategoryQueryResult { CategoryID = x.CategoryID, Name = x.Name }).ToList();
    }
}