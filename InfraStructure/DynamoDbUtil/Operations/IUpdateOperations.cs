namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    public interface IUpdateOperations<T> where T : class
    {
        // �򥻧�s�ާ@
        Task UpdateAsync(T item, CancellationToken cancellationToken = default);
        
        // ���󦡧�s
        Task UpdateAsync(T item, string conditionExpression, CancellationToken cancellationToken = default);
        
        // �ϥΧ�s��F������s
        Task UpdateWithExpressionAsync(
            object hashKey,
            string updateExpression,
            Dictionary<string, Amazon.DynamoDBv2.Model.AttributeValue>? expressionAttributeValues = null,
            Dictionary<string, string>? expressionAttributeNames = null,
            string? conditionExpression = null,
            CancellationToken cancellationToken = default);
            
        // �ϥνƦX�䪺��s��F��
        Task UpdateWithExpressionAsync(
            object hashKey,
            object rangeKey,
            string updateExpression,
            Dictionary<string, Amazon.DynamoDBv2.Model.AttributeValue>? expressionAttributeValues = null,
            Dictionary<string, string>? expressionAttributeNames = null,
            string? conditionExpression = null,
            CancellationToken cancellationToken = default);
            
        // ��l�ʼƭȼW��
        Task IncrementAsync(object hashKey, string attributeName, decimal incrementValue, CancellationToken cancellationToken = default);
        Task IncrementAsync(object hashKey, object rangeKey, string attributeName, decimal incrementValue, CancellationToken cancellationToken = default);
        
        // �妸��s
        Task BatchUpdateAsync(IEnumerable<T> items, CancellationToken cancellationToken = default);
    }
}