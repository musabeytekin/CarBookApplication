namespace CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;

public class DeleteFooterAddressCommand : IRequest
{
    public DeleteFooterAddressCommand(int footerAddressId)
    {
        FooterAddressID = footerAddressId;
    }

    public int FooterAddressID { get; set; }
}