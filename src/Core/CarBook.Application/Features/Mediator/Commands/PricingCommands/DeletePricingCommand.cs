namespace CarBook.Application.Features.Mediator.Commands.PricingCommands;

public class DeletePricingCommand : IRequest
{
    public DeletePricingCommand(int pricingId)
    {
        PricingID = pricingId;
    }

    public int PricingID { get; set; }
}