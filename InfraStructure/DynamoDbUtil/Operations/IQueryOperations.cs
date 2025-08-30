using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;

namespace ThreadsHome.InfraStructure.DynamoDbUtil.Operations
{
    public interface IQueryOperations<T> where T : class
    {
        // 虏虫琩高
        Task<List<T>> QueryAsync(object hashKeyValue, CancellationToken cancellationToken = default);
        
        // ㄏノ Dictionary<string, AttributeValue> 琩高
        Task<List<T>> QueryAsync(Dictionary<string, AttributeValue> keyConditions, CancellationToken cancellationToken = default);
        
        // 秈顶琩高や穿縵匡笷Α
        Task<List<T>> QueryAsync(
            Dictionary<string, AttributeValue> keyConditions, 
            string? filterExpression = null, 
            Dictionary<string, AttributeValue>? expressionAttributeValues = null,
            Dictionary<string, string>? expressionAttributeNames = null,
            bool scanIndexForward = true,
            int? limit = null,
            CancellationToken cancellationToken = default);
            
        // 琩高疭﹚ま
        Task<List<T>> QueryIndexAsync(
            string indexName,
            object hashKeyValue,
            CancellationToken cancellationToken = default);
            
        // だ琩高
        Task<(List<T> Items, string? LastEvaluatedKey)> QueryWithPaginationAsync(
            Dictionary<string, AttributeValue> keyConditions,
            string? lastEvaluatedKey = null,
            int? pageSize = null,
            CancellationToken cancellationToken = default);
    }
}