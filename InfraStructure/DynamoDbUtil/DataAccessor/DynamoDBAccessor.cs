using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Polly.Retry;

namespace ThreadsHome.InfraStructure.DynamoDbUtil.DataAccessor
{
    internal class DynamoDBAccessor : IDynamoDBAccessor
    {
        public IAmazonDynamoDB Client => throw new NotImplementedException();

        public IDynamoDBContext Context => throw new NotImplementedException();

        public AsyncRetryPolicy PollyRetryPolicy => throw new NotImplementedException();
    }
}
