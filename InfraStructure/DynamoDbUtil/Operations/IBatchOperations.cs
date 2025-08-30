namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    public interface IBatchOperations<T> where T : class
    {
        // �妸�g�J�ާ@
        Task BatchWriteAsync(IEnumerable<T> items, CancellationToken cancellationToken = default);
        
        // �妸Ū���ާ@
        Task<List<T>> BatchGetAsync(IEnumerable<object> keys, CancellationToken cancellationToken = default);
        Task<List<T>> BatchGetAsync(IEnumerable<(object hashKey, object rangeKey)> keys, CancellationToken cancellationToken = default);
        
        // �妸�R���ާ@
        Task BatchDeleteAsync(IEnumerable<T> items, CancellationToken cancellationToken = default);
        Task BatchDeleteAsync(IEnumerable<object> keys, CancellationToken cancellationToken = default);
        Task BatchDeleteAsync(IEnumerable<(object hashKey, object rangeKey)> keys, CancellationToken cancellationToken = default);
    }
}