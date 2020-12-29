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

        public LatePreClassicPeriodSettings LatePreClassicPeriodSettings { get; init; }
        public ShadowsOfXitleSettings ShadowsOfXitleSettings { get; init;  }
        public PromoSettings PromoSettings { get; init;  }
    }
}
