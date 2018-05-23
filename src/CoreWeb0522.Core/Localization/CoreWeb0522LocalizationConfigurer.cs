using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CoreWeb0522.Localization
{
    public static class CoreWeb0522LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CoreWeb0522Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CoreWeb0522LocalizationConfigurer).GetAssembly(),
                        "CoreWeb0522.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
