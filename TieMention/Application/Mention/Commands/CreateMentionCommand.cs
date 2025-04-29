using MediatR;
using TieMention.Core.Models;

namespace TieMention.Application.Mention.Commands;

// Define o Command (dados necessários para criar um post)
public record CreateMentionCommand(
    string Title,
    string Content,
    Guid AuthorId // Ou string AuthorId se usar ASP.NET Core Identity
) : IRequest<Result<Guid>>; // Retorna Result<T> (padrão funcional para erros)

// Tipos auxiliares (opcional)
public sealed record Result<T>(T Value, bool IsSuccess, string Error)
{
    public static Result<T> Success(T value) => new(value, true, null!);
    public static Result<T> Failure(string error) => new(default!, false, error);
}