using Amazon.DynamoDBv2.DataModel;

namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    /// <summary>
    /// 組合所有 CRUD 操作的完整 Repository 介面
    /// </summary>
    /// <typeparam name="T">實體類型</typeparam>
    public interface IRepository<T> : 
        IReadOperations<T>, 
        IWriteOperations<T>, 
        IUpdateOperations<T>,
        IDeleteOperations<T>, 
        IQueryOperations<T>,
        IBatchOperations<T>
        where T : class
    {
        // 可以在這裡加入特殊的組合操作
        
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
        
        /// <summary>
        /// 取得符合條件的項目總數
        /// </summary>
        Task<int> CountAsync(List<ScanCondition> conditions, CancellationToken cancellationToken = default);
    }
}