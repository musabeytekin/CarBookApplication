namespace CarBook.Application.Features.Mediator.Commands.CarCommands;

public class CreateCarCommand : IRequest
{
    public string Model { get; set; }

    public int BrandID { get; set; }
    public string CoverImageUrl { get; set; }
    public int Km { get; set; }
    public string Transmission { get; set; }
    public byte Seat { get; set; }
    public string Fuel { get; set; }
    public string Luggage { get; set; }
    public string BigImageUrl { get; set; }
}