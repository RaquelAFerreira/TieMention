using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TieMention.Domain.Entities;
using TieMention.Application.Interfaces;

namespace TieMention.Application.Mentions.Commands;

public class CreateMentionHandler : IRequestHandler<CreateMentionCommand, Guid>
{
    private readonly IRepository<Mention> _repo;

    public CreateMentionHandler(IRepository<Mention> repo) => _repo = repo;

    public async Task<Guid> Handle(CreateMentionCommand request, CancellationToken ct)
    {
        var mention = new Mention
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Category = request.Category
        };
        await _repo.AddAsync(mention);
        return mention.Id;
    }
}