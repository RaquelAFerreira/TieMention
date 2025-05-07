using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TieMention.Domain.Entities;
using TieMention.Application.Interfaces;

namespace TieMention.Application.Mentions.Commands;

public record CreateMentionCommand(string Name, Category Category) : IRequest<Guid>;
