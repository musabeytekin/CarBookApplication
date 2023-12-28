namespace CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;

public class DeleteSocialMediaCommand : IRequest
{
    public DeleteSocialMediaCommand(int socialMediaId)
    {
        SocialMediaID = socialMediaId;
    }

    public int SocialMediaID { get; set; }
}