namespace CarBook.Application.Features.Mediator.Commands.FeatureCommands;

public class DeleteFeatureCommand : IRequest
{
    public DeleteFeatureCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}