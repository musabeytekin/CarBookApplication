namespace CarBook.Application.Features.Mediator.Queries.CategoryQueries;

public class GetCategoryByIdQuery : IRequest<GetCategoryByIdQueryResult>
{
    public GetCategoryByIdQuery(int categoryId)
    {
        CategoryID = categoryId;
    }

    public int CategoryID { get; set; }
}