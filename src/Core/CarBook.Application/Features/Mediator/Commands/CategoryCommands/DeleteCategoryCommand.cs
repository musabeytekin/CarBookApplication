namespace CarBook.Application.Features.Mediator.Commands.CategoryCommands;

public class DeleteCategoryCommand : IRequest
{
    public DeleteCategoryCommand(int categoryId)
    {
        CategoryID = categoryId;
    }

    public int CategoryID { get; set; }
}