namespace CarBook.Application.Features.Mediator.Queries.SocialMediaQueries;

public class GetSocialMediaByIdQuery : IRequest<GetSocialMediaByIdQueryResult>
{
    public GetSocialMediaByIdQuery(int socialMediaId)
    {
        SocialMediaID = socialMediaId;
    }

    public int SocialMediaID { get; set; }
}