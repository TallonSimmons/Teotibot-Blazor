using MediatR;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Teotibot.Client.Store;
using Teotibot.Client.Store.Mutations;

namespace Teotibot.Client.Components
{
    public abstract class StoreComponent<TStore> : ComponentBase where TStore : StateBase
    {
        [Inject]
        IMediator Mediator { get; set; }
        [Inject]
        TStore Store { get; set; }

        public async Task CommitMutation(Mutation<TStore> mutation)
        {
            var newStoreInstance = await Mediator.Send(mutation);
            Store = newStoreInstance;
        }
    }
}
