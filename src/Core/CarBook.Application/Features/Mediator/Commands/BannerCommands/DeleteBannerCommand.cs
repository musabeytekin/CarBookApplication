namespace CarBook.Application.Features.Mediator.Commands.BannerCommands;

public class DeleteBannerCommand : IRequest
{
    public DeleteBannerCommand(int bannerId)
    {
        BannerID = bannerId;
    }

    public int BannerID { get; set; }
}