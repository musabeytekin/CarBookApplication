namespace CarBook.Application.Features.Mediator.Commands.BrandCommands;

public class CreateBrandCommand : IRequest
{
    public string Name { get; set; }
}