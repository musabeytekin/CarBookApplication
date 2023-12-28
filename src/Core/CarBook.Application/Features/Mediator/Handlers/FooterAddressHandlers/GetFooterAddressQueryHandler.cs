namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers;

public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
{
    private readonly IRepository<FooterAddress> _repository;

    public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
    {
        var footerAddresses = await _repository.GetAllAsync();
        var footerAddressResults = footerAddresses.Select(x => new GetFooterAddressQueryResult
        {
            FooterAddressID = x.FooterAddressID,
            Description = x.Description,
            Address = x.Address,
            Phone = x.Phone,
            Email = x.Email
        }).ToList();

        return footerAddressResults;
    }
}