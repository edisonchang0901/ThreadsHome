using Amazon.DynamoDBv2.DataModel;

namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    public interface IReadOperations<T> where T : class
    {
        Task<T?> GetByIdAsync(object id, CancellationToken cancellationToken = default);
        Task<T?> GetByCompositeKeyAsync(object hashKey, object rangeKey, CancellationToken cancellationToken = default);
        Task<List<T>> BatchGetAsync(IEnumerable<object> keys, CancellationToken cancellationToken = default);
        Task<List<T>> ScanAsync(List<ScanCondition>? conditions = null, CancellationToken cancellationToken = default);
        Task<List<T>> ScanAsync(
            List<ScanCondition>? conditions = null,
            string? filterExpression = null,
            Dictionary<string, Amazon.DynamoDBv2.Model.AttributeValue>? expressionAttributeValues = null,
            Dictionary<string, string>? expressionAttributeNames = null,
            int? limit = null,
            CancellationToken cancellationToken = default);
        Task<(List<T> Items, string? LastEvaluatedKey)> ScanWithPaginationAsync(
            List<ScanCondition>? conditions = null,
            string? lastEvaluatedKey = null,
            int? pageSize = null,
            CancellationToken cancellationToken = default);
    }
}
