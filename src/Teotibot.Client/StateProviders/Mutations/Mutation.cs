using MediatR;

namespace Teotibot.Client.Store.Mutations
{
    public record Mutation<TStore> : IRequest<TStore>
        where TStore : StateBase
    {
    }
}
