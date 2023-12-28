namespace CarBook.Application.Features.Mediator.Queries.TestimonialQueries;

public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>
{
    public GetTestimonialByIdQuery(int testimonialId)
    {
        TestimonialID = testimonialId;
    }

    public int TestimonialID { get; set; }
    
}