using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;

namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    public interface IQueryOperations<T> where T : class
    {
        // ²��d��
        Task<List<T>> QueryAsync(object hashKeyValue, CancellationToken cancellationToken = default);
        
        // �ϥ� Dictionary<string, AttributeValue> ���d��
        Task<List<T>> QueryAsync(Dictionary<string, AttributeValue> keyConditions, CancellationToken cancellationToken = default);
        
        // �i���d�ߡA�䴩�z���F��
        Task<List<T>> QueryAsync(
            Dictionary<string, AttributeValue> keyConditions, 
            string? filterExpression = null, 
            Dictionary<string, AttributeValue>? expressionAttributeValues = null,
            Dictionary<string, string>? expressionAttributeNames = null,
            bool scanIndexForward = true,
            int? limit = null,
            CancellationToken cancellationToken = default);
            
        // �d�߯S�w����
        Task<List<T>> QueryIndexAsync(
            string indexName,
            object hashKeyValue,
            CancellationToken cancellationToken = default);
            
        // �����d��
        Task<(List<T> Items, string? LastEvaluatedKey)> QueryWithPaginationAsync(
            Dictionary<string, AttributeValue> keyConditions,
            string? lastEvaluatedKey = null,
            int? pageSize = null,
            CancellationToken cancellationToken = default);
    }
}