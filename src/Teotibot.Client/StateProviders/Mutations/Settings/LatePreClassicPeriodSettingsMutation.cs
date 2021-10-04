using System.Threading;
using System.Threading.Tasks;
using Teotibot.Core.Entities;
using Teotibot.Core.ValueObjects.Settings;

namespace Teotibot.Client.Store.Mutations.Settings
{
    public record LatePreClassicPeriodSettingsMutation : Mutation<AppState>
    {
        public LatePreClassicPeriodSettingsMutation(LatePreClassicPeriodSettings latePreClassicPeriodSettings)
        {
            LatePreClassicPeriodSettings = latePreClassicPeriodSettings;
        }

        public LatePreClassicPeriodSettings LatePreClassicPeriodSettings { get; }
    }

    public class LatePreClassicPeriodSettingsMutationHandler : IMutationHandler<LatePreClassicPeriodSettingsMutation, AppState>
    {
        public LatePreClassicPeriodSettingsMutationHandler(AppState store)
        {
            Store = store;
        }

        public AppState Store { get; }

        public Task<AppState> Handle(LatePreClassicPeriodSettingsMutation request, CancellationToken cancellationToken)
        {
            var oldGame = Store.Game;
            var newSettings = Store.Game.Settings with { LatePreClassicPeriodSettings = request.LatePreClassicPeriodSettings };
            var newGame = new Game(oldGame.Id, newSettings, oldGame.Pyramid, oldGame.SetAsideTile, oldGame.TopDirectionTile, oldGame.BottomDirectionTile, oldGame.ActiveTile);

            return Task.FromResult(new AppState(newGame));
        }
    }
}
