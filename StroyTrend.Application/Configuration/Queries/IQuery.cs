using MediatR;

namespace StroyTrend.Application.Configuration.Queries;

public interface IQuery<out TResult> : IRequest<TResult>
{
    
}