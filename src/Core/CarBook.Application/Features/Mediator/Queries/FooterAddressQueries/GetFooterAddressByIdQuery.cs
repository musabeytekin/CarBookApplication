namespace CarBook.Application.Features.Mediator.Queries.FooterAddressQueries;

public class GetFooterAddressByIdQuery : IRequest<GetFooterAddressByIdQueryResult>
{
    public GetFooterAddressByIdQuery(int footerAddressId)
    {
        FooterAddressID = footerAddressId;
    }

    public int FooterAddressID { get; set; }
}