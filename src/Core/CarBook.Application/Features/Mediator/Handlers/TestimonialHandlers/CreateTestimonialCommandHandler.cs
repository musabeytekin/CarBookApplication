namespace CarBook.Application.Features.Mediator.Handlers.TestimonialHandlers;

public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public CreateTestimonialCommandHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
    {
        var testimonial = new Testimonial
        {
            Name = request.Name,
            Title = request.Title,
            Comment = request.Comment,
            ImageUrl = request.ImageUrl
        };

        await _repository.CreateAsync(testimonial);
    }
}