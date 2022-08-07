namespace ElasticDataGenerator.Interfaces;

/// <summary>
///     ElasticSearch available indexes
/// </summary>
public interface IElasticIndexSettings
{
    /// <summary>
    ///     Audit logs from services
    /// </summary>
    public string? Log { get; set; }
}