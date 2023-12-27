namespace CarBook.Application.Features.Mediator.Commands.BrandCommands;

public class DeleteBrandCommand : IRequest
{
    public DeleteBrandCommand(int BrandId)
    {
        BrandID = BrandId;
    }

    public int BrandID { get; set; }
}