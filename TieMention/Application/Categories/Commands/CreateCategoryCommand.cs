using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TieMention.Domain.Entities;
using TieMention.Application.Interfaces;

namespace TieMention.Application.Categories.Commands;

public record CreateCategoryCommand(string Name) : IRequest<Guid>;
