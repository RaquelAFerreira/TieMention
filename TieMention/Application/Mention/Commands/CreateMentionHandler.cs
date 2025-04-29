using TieMention.Core.Models;
using TieMention.Core.Interfaces.Repositories;
using TieMention.Application.Mention.Commands;
using MediatR;

public sealed class CreateMentionHandler : IRequestHandler<CreateMentionCommand, Result<Guid>>
{
    private readonly IMentionRepository _mentionRepository;

    public CreateMentionHandler(IMentionRepository mentionRepository)
    {
        _mentionRepository = mentionRepository;
    }

    public async Task<Result<Guid>> Handle(CreateMentionCommand command, CancellationToken ct)
    {
        // var mention = Mention.Create(command.Title, command.Content, command.AuthorId);
        // await _mentionRepository.AddAsync(mention);
        // return Result.Success(mention.Id); 

        return null;
    }
}
