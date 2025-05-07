using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TieMention.Domain.Entities;
using TieMention.Application.Interfaces;

namespace TieMention.Application.Categories.Queries;

public class GetCategoryHandler : IRequestHandler<GetCategoryQuery, List<Category>>
{
    private readonly IRepository<Category> _repo;
    public GetCategoryHandler(IRepository<Category> repo) => _repo = repo;

    public async Task<List<Category>> Handle(GetCategoryQuery request, CancellationToken ct) =>
        await _repo.GetAllAsync();
}