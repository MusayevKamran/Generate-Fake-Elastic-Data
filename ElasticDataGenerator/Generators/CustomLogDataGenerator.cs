using ElasticDataGenerator.Interfaces;
using ElasticDataGenerator.Models;
using ElasticDataGenerator.Patterns.Template;
using ElasticDataGenerator.Resources;

namespace ElasticDataGenerator.Generators;

/// <summary>
///     Player Changes Log Generator models
/// </summary>
internal class CustomLogDataGenerator : LogDataGenerator<LogDomainModel, LogConfigModel>
{
    /// <summary>
    ///     Player Changes Log Generator
    /// </summary>
    public CustomLogDataGenerator(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    /// <summary>
    ///     Set Index of elastic
    /// </summary>
    protected override string? GetIndex(IElasticIndexSettings indexes)
    {
        return indexes.Log;
    }

    /// <summary>
    ///     Set identifier of index
    /// </summary>
    protected override string GetIdentifierName()
    {
        return nameof(LogDomainModel.Id);
    }

    /// <summary>
    ///     Override resource data
    /// </summary>
    protected override byte[]? GetResourceData()
    {
        return Resource.logData;
    }

    /// <summary>
    ///     Create model for inserting data to elastic
    /// </summary>
    /// <returns>PlayerChangesLogResponseDto</returns>
    protected override Task<LogDomainModel> CreateNewDtoAsync()
    {
        var id = Guid.NewGuid();

        var dto = new LogDomainModel
        {
            Id = id,
            Message = ConfigurationModel?.Message + id
        };

        return Task.FromResult(dto);
    }
}