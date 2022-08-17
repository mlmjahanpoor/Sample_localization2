using Microsoft.Extensions.Localization;

namespace Sample_Localization.Localizations
{
    public static class LocalizationConfig
    {
        public static void SetResources (this LocalizationOptions options)
        {
            options.ResourcesPath = "Resources";
        }
        public static RequestLocalizationOptions Config()
        {
            var supportedCultures = new[] { "fa-IR", "en-US" };
            var localizationOptions = new RequestLocalizationOptions()
                .SetDefaultCulture(supportedCultures[0])
                .AddSupportedCultures(supportedCultures);

            return localizationOptions;
        }
    }
}
