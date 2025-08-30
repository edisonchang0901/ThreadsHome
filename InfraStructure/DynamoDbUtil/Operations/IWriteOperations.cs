namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    public interface IWriteOperations<T> where T : class
    {
        Task CreateAsync(T item, CancellationToken cancellationToken = default);
        Task UpdateAsync(T item, CancellationToken cancellationToken = default);
        Task UpsertAsync(T item, CancellationToken cancellationToken = default);
    }
}
