namespace CarBook.Application.Features.Mediator.Commands.ServiceCommands;

public class DeleteServiceCommand : IRequest
{
    public DeleteServiceCommand(int serviceId)
    {
        ServiceID = serviceId;
    }

    public int ServiceID { get; set; }
}