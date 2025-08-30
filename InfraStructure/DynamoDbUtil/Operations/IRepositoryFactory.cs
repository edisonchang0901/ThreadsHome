namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    /// <summary>
    /// Repository 工廠介面，用於建立特定類型的 Repository
    /// </summary>
    public interface IRepositoryFactory
    {
        /// <summary>
        /// 建立指定類型的 Repository
        /// </summary>
        /// <typeparam name="T">實體類型</typeparam>
        /// <returns>Repository 實例</returns>
        IRepository<T> CreateRepository<T>() where T : class;
        
        /// <summary>
        /// 建立指定類型的唯讀 Repository
        /// </summary>
        /// <typeparam name="T">實體類型</typeparam>
        /// <returns>唯讀 Repository 實例</returns>
        IReadOnlyRepository<T> CreateReadOnlyRepository<T>() where T : class;
    }
    
    /// <summary>
    /// 唯讀 Repository 介面
    /// </summary>
    /// <typeparam name="T">實體類型</typeparam>
    public interface IReadOnlyRepository<T> : 
        IReadOperations<T>, 
        IQueryOperations<T>
        where T : class
    {
        /// <summary>
        /// 檢查項目是否存在
        /// </summary>
        Task<bool> ExistsAsync(object id, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// 檢查項目是否存在（複合鍵）
        /// </summary>
        Task<bool> ExistsAsync(object hashKey, object rangeKey, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// 取得項目總數
        /// </summary>
        Task<int> CountAsync(CancellationToken cancellationToken = default);
    }
}