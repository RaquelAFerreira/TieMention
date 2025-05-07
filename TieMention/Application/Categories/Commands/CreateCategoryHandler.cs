using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TieMention.Domain.Entities;
using TieMention.Application.Interfaces;

namespace TieMention.Application.Categories.Commands;

public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, Guid>
{
    private readonly IRepository<Category> _repo;

    public CreateCategoryHandler(IRepository<Category> repo) => _repo = repo;

    public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken ct)
    {
        var category = new Category { Id = Guid.NewGuid(), Name = request.Name };
        await _repo.AddAsync(category);
        return category.Id;
    }
}