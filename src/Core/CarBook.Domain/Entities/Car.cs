namespace CarBook.Domain.Entities;

public class Car
{
    public int CarID { get; set; }
    public int BrandID { get; set; }
    public Brand Brand { get; set; }
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
    public int Km { get; set; }
    public string Transmission { get; set; }
    public byte Seat { get; set; }
    public string Fuel { get; set; }
    public string Luggage { get; set; }
    public string BigImageUrl { get; set; }

    public List<CarFeature> Features { get; set; }
    public List<CarDescription> Descriptions { get; set; }
    public List<CarPricing> Pricings { get; set; }
    
}