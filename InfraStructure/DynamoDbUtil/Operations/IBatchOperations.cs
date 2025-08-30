namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    public interface IBatchOperations<T> where T : class
    {
        // 批次寫入操作
        Task BatchWriteAsync(IEnumerable<T> items, CancellationToken cancellationToken = default);
        
        // 批次讀取操作
        Task<List<T>> BatchGetAsync(IEnumerable<object> keys, CancellationToken cancellationToken = default);
        Task<List<T>> BatchGetAsync(IEnumerable<(object hashKey, object rangeKey)> keys, CancellationToken cancellationToken = default);
        
        // 批次刪除操作
        Task BatchDeleteAsync(IEnumerable<T> items, CancellationToken cancellationToken = default);
        Task BatchDeleteAsync(IEnumerable<object> keys, CancellationToken cancellationToken = default);
        Task BatchDeleteAsync(IEnumerable<(object hashKey, object rangeKey)> keys, CancellationToken cancellationToken = default);
    }
}