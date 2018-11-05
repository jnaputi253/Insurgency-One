using System.Threading.Tasks;
using InsurgencyOne.Helpers;
using InsurgencyOne.Results;
using InsurgencyOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsurgencyOne.Controllers
{
    [ApiController]
    [Route("/api/v1/dynamo")]
    public class DynamoDbController : Controller
    {
        private readonly DynamoDbService _dynamoDbService;

        public DynamoDbController(DynamoDbService dynamoDbService)
        {
            _dynamoDbService = dynamoDbService;
        }

        [HttpGet]
        [Route("init")]
        public async Task<IActionResult> CreateDefaultTable()
        {
            var createTableRequest = DynamoDbHelper.GenerateCreateTableRequest();
            IResult result = await _dynamoDbService.CreateTableAsync(createTableRequest);

            return new ObjectResult(result);
        }
    }
}
