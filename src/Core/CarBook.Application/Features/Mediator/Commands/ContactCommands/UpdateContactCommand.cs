namespace CarBook.Application.Features.Mediator.Commands.ContactCommands;

public class UpdateContactCommand : IRequest
{
    public int ContactID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public DateTime SendDate { get; set; }
}