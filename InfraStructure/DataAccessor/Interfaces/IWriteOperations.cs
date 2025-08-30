namespace ThreadsHome.InfraStructure.DataAccessor.Interfaces
{
    internal interface IWriteOperations<T> where T : class
    {
        Task CreateAsync(T item, CancellationToken cancellationToken = default);
        Task UpdateAsync(T item, CancellationToken cancellationToken = default);
        Task UpsertAsync(T item, CancellationToken cancellationToken = default);
    }
}