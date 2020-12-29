using MediatR;

namespace Teotibot.Client.Store.Mutations
{
    public interface IMutationHandler<TMutation, TStore> : IRequestHandler<TMutation, TStore>
        where TMutation : Mutation<TStore>
        where TStore : StoreBase
    {
    }
}
