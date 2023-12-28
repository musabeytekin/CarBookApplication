namespace CarBook.Application.Features.Mediator.Handlers.TestimonialHandlers;

public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
{
    private readonly IRepository<Testimonial> _repository;

    public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
    {
        var testimonials = await _repository.GetAllAsync();
        return testimonials.Select(x => new GetTestimonialQueryResult
        {
            TestimonialID = x.TestimonialID,
            Name = x.Name,
            Title = x.Title,
            Comment = x.Comment,
            ImageUrl = x.ImageUrl
        }).ToList();
    }
}