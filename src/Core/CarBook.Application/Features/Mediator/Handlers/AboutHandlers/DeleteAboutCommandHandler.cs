
using CarBook.Application.Features.Mediator.Commands.AboutCommands;

namespace CarBook.Application.Features.Mediator.Handlers.AboutHandlers;

public class DeleteAboutCommandHandler : IRequestHandler<DeleteAboutCommand>
{
    private readonly IRepository<About> _repository;

    public DeleteAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteAboutCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.DeleteAsync(value);
    }
}