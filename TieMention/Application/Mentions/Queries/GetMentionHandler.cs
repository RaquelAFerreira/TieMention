using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TieMention.Domain.Entities;
using TieMention.Application.Interfaces;

namespace TieMention.Application.Mentions.Queries;

public class GetMentionHandler : IRequestHandler<GetMentionQuery, List<Mention>>
{
    private readonly IRepository<Mention> _repo;
    public GetMentionHandler(IRepository<Mention> repo) => _repo = repo;

    public async Task<List<Mention>> Handle(GetMentionQuery request, CancellationToken ct) =>
        await _repo.GetAllAsync();
}