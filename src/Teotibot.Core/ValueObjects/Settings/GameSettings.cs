using System;

namespace Teotibot.Core.ValueObjects.Settings
{
    public class GameSettings
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

        public override bool Equals(object obj)
        {
            return !(obj is null) && obj is GameSettings settings &&
                    settings.LatePreClassicPeriodSettings.Equals(LatePreClassicPeriodSettings) &&
                    settings.ShadowsOfXitleSettings.Equals(ShadowsOfXitleSettings) &&
                    settings.PromoSettings.Equals(PromoSettings);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(LatePreClassicPeriodSettings, ShadowsOfXitleSettings, PromoSettings);
        }

        public static bool operator ==(GameSettings a, GameSettings b) => a?.Equals(b) ?? false;
        public static bool operator !=(GameSettings a, GameSettings b) => !a?.Equals(b) ?? true;
    }
}
