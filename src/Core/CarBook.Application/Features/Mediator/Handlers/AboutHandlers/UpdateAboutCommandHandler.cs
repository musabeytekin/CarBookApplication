using CarBook.Application.Features.Mediator.Commands.AboutCommands;

namespace CarBook.Application.Features.Mediator.Handlers.AboutHandlers;

public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand>
{
    private readonly IRepository<About> _repository;

    public UpdateAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.AboutID);
        value.Title = request.Title;
        value.Description = request.Description;
        value.ImageUrl = request.ImageUrl;
        await _repository.UpdateAsync(value);
    }
}