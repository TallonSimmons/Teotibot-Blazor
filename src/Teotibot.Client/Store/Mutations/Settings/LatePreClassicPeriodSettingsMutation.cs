using System.Threading;
using System.Threading.Tasks;
using Teotibot.Core.Entities;
using Teotibot.Core.ValueObjects.Settings;

namespace Teotibot.Client.Store.Mutations.Settings
{
    public record LatePreClassicPeriodSettingsMutation : Mutation<AppStore>
    {
        public LatePreClassicPeriodSettingsMutation(LatePreClassicPeriodSettings latePreClassicPeriodSettings)
        {
            LatePreClassicPeriodSettings = latePreClassicPeriodSettings;
        }

        public LatePreClassicPeriodSettings LatePreClassicPeriodSettings { get; }
    }

    public class LatePreClassicPeriodSettingsMutationHandler : IMutationHandler<LatePreClassicPeriodSettingsMutation, AppStore>
    {
        public LatePreClassicPeriodSettingsMutationHandler(AppStore store)
        {
            Store = store;
        }

        public AppStore Store { get; }

        public Task<AppStore> Handle(LatePreClassicPeriodSettingsMutation request, CancellationToken cancellationToken)
        {
            var oldGame = Store.Game;
            var newSettings = Store.Game.Settings with { LatePreClassicPeriodSettings = request.LatePreClassicPeriodSettings };
            var newGame = new Game(oldGame.Id, newSettings, oldGame.Pyramid, oldGame.SetAsideTile, oldGame.TopDirectionTile, oldGame.BottomDirectionTile, oldGame.ActiveTile);

            return Task.FromResult(new AppStore(newGame));
        }
    }
}
