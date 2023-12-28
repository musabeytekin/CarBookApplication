namespace CarBook.Application.Features.Mediator.Commands.ContactCommands;

public class DeleteContactCommand : IRequest
{
    public DeleteContactCommand(int contactId)
    {
        ContactID = contactId;
    }

    public int ContactID { get; set; }
}