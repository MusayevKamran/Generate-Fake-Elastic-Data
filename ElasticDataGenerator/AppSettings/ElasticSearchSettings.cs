namespace ElasticDataGenerator.AppSettings;

/// <summary>
///     Elastic service settings model
/// </summary>
public class ElasticSearchSettings : IElasticSearchSettings
{
    public ElasticSearchSettings(IConfiguration configuration)
    {
        ApplySettings(configuration);
    }

    /// <summary>
    ///     Audit logs from services
    /// </summary>
    public string? Log { get; set; }

    /// <summary>
    ///     Connection URL for ELK
    /// </summary>
    public string? ConnectionUrl { get; set; }

    /// <summary>
    ///     UserName for ELK
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    ///     Password for ELK
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    ///     Apply ELK indexes configs
    /// </summary>
    private void ApplySettings(IConfiguration config)
    {
        ConnectionUrl = config["ElasticSearch:ConnectionString"];
        UserName = config["ElasticSearch:UserName"];
        Password = config["ElasticSearch:Password"];
        Log = config["ElasticSearch:Indexes:Log"];
    }
}