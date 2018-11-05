using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using JetBrains.Annotations;

namespace InsurgencyOne.Database
{
    /// <summary>
    /// This class is responsible for actions that deal with DynamoDB table creations, deletions, or modifications.
    /// </summary>
    public class DynamoDbHandler
    {
        private readonly IAmazonDynamoDB _dynamoDb;

        public DynamoDbHandler(IAmazonDynamoDB dynamoDb)
        {
            _dynamoDb = dynamoDb;
        }

        public async Task CreateTableAsync([NotNull] CreateTableRequest createTableRequest)
        {
            await _dynamoDb.CreateTableAsync(createTableRequest);
        }
    }
}
