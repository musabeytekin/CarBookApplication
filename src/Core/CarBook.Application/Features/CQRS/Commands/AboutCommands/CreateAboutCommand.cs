using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Commands.AboutCommands;

public class CreateAboutCommand
{
    public CreateAboutCommand(string title, string description, string imageUrl)
    {
        Title = title;
        Description = description;
        ImageUrl = imageUrl;
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    
}