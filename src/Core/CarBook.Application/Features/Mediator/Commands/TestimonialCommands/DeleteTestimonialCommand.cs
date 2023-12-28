namespace CarBook.Application.Features.Mediator.Commands.TestimonialCommands;

public class DeleteTestimonialCommand : IRequest
{
    public DeleteTestimonialCommand(int testimonialId)
    {
        TestimonialID = testimonialId;
    }

    public int TestimonialID { get; set; }
}