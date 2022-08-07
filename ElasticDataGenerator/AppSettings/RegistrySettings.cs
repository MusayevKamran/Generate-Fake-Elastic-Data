using bgTeam.Extensions;
using ElasticDataGenerator.Interfaces;

namespace ElasticDataGenerator.AppSettings;

/// <summary>
///     Registry of settings
/// </summary>
public static class RegistrySettings
{
    /// <summary>
    ///     Register app settings by sections
    /// </summary>
    public static void RegisterSettings(this IServiceCollection services)
    {
        services.AddSettings<IElasticSearchSettings, ElasticSearchSettings>();
        services.AddSettings<IElasticIndexSettings, ElasticSearchSettings>();
    }
}