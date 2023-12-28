namespace CarBook.Application.Features.Mediator.Commands.CarCommands;

public class DeleteCarCommand : IRequest
{
    public DeleteCarCommand(int carId)
    {
        CarID = carId;
    }

    public int CarID { get; set; }
}