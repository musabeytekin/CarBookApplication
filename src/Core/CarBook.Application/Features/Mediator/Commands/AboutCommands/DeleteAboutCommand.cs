namespace CarBook.Application.Features.Mediator.Commands.AboutCommands;

public class DeleteAboutCommand : IRequest
{
    public DeleteAboutCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }

}