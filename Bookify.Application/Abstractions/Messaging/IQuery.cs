using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application.Abstractions.Messaging;

public interface IQuery<IResponse> : IRequest<Result<IResponse>>
{
}
