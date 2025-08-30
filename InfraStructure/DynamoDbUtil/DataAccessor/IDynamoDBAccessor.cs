using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Polly.Retry;

namespace ThreadsHome.InfraStructure.DynamoDbUtil.DataAccessor
{
    internal interface IDynamoDBAccessor
    {
        IAmazonDynamoDB Client { get; }

        IDynamoDBContext Context { get; }

        AsyncRetryPolicy PollyRetryPolicy { get; }
    }
}
