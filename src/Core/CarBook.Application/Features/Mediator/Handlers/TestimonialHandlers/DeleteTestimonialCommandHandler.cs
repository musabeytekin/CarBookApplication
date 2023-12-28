namespace CarBook.Application.Features.Mediator.Handlers.TestimonialHandlers;

public class DeleteTestimonialCommandHandler : IRequestHandler<DeleteTestimonialCommand>
{
    private readonly IRepository<Testimonial> _repository;

    public DeleteTestimonialCommandHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteTestimonialCommand request, CancellationToken cancellationToken)
    {
        var testimonial = await _repository.GetByIdAsync(request.TestimonialID);
        await _repository.DeleteAsync(testimonial);
    }
}