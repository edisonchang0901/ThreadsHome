namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    public interface IUpdateOperations<T> where T : class
    {
        // 基本更新操作
        Task UpdateAsync(T item, CancellationToken cancellationToken = default);
        
        // 條件式更新
        Task UpdateAsync(T item, string conditionExpression, CancellationToken cancellationToken = default);
        
        // 使用更新表達式的更新
        Task UpdateWithExpressionAsync(
            object hashKey,
            string updateExpression,
            Dictionary<string, Amazon.DynamoDBv2.Model.AttributeValue>? expressionAttributeValues = null,
            Dictionary<string, string>? expressionAttributeNames = null,
            string? conditionExpression = null,
            CancellationToken cancellationToken = default);
            
        // 使用複合鍵的更新表達式
        Task UpdateWithExpressionAsync(
            object hashKey,
            object rangeKey,
            string updateExpression,
            Dictionary<string, Amazon.DynamoDBv2.Model.AttributeValue>? expressionAttributeValues = null,
            Dictionary<string, string>? expressionAttributeNames = null,
            string? conditionExpression = null,
            CancellationToken cancellationToken = default);
            
        // 原子性數值增減
        Task IncrementAsync(object hashKey, string attributeName, decimal incrementValue, CancellationToken cancellationToken = default);
        Task IncrementAsync(object hashKey, object rangeKey, string attributeName, decimal incrementValue, CancellationToken cancellationToken = default);
        
        // 批次更新
        Task BatchUpdateAsync(IEnumerable<T> items, CancellationToken cancellationToken = default);
    }
}