namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    public interface IDeleteOperations<T> where T : class
    {
        Task DeleteAsync(T item, CancellationToken cancellationToken = default);
        Task DeleteByIdAsync(object id, CancellationToken cancellationToken = default);
        Task DeleteByCompositeKeyAsync(object hashKey, object rangeKey, CancellationToken cancellationToken = default);
        Task BatchDeleteAsync(IEnumerable<T> items, CancellationToken cancellationToken = default);
    }
}