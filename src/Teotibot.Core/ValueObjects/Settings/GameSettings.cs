using System;

namespace Teotibot.Core.ValueObjects.Settings
{
    public record GameSettings
    {
        public GameSettings(LatePreClassicPeriodSettings latePreClassicPeriodSettings, ShadowsOfXitleSettings shadowsOfXitleSettings, PromoSettings promoSettings)
        {
            LatePreClassicPeriodSettings = latePreClassicPeriodSettings;
            ShadowsOfXitleSettings = shadowsOfXitleSettings;
            PromoSettings = promoSettings;
        }

        public LatePreClassicPeriodSettings LatePreClassicPeriodSettings { get; }
        public ShadowsOfXitleSettings ShadowsOfXitleSettings { get; }
        public PromoSettings PromoSettings { get; }
    }
}
