namespace CarBook.Application.Features.Mediator.Commands.AboutCommands;

public class UpdateAboutCommand : IRequest
{
    public int AboutID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

}