namespace CarBook.Application.Features.Mediator.Handlers.TestimonialHandlers;

public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
    {
        var testimonial = await _repository.GetByIdAsync(request.TestimonialID);
        testimonial.Name = request.Name;
        testimonial.Title = request.Title;
        testimonial.Comment = request.Comment;
        testimonial.ImageUrl = request.ImageUrl;
        await _repository.UpdateAsync(testimonial);
    }
}