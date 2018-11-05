using System.Threading.Tasks;
using Amazon.DynamoDBv2.Model;
using InsurgencyOne.Database;
using InsurgencyOne.Results;

namespace InsurgencyOne.Services
{
    public class DynamoDbService
    {
        private readonly DynamoDbHandler _dynamoDbHandler;

        public DynamoDbService(DynamoDbHandler dynamoDbHandler)
        {
            _dynamoDbHandler = dynamoDbHandler;
        }

        public async Task<IResult> CreateTableAsync(CreateTableRequest createTableRequest)
        {
            try
            {
                await _dynamoDbHandler.CreateTableAsync(createTableRequest);
            }
            catch (ResourceInUseException e)
            {
                return new CreateTableResult(false, e.Message);
            }

            return new CreateTableResult(true, string.Empty);
        }
    }
}
