using System.Collections.Generic;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace InsurgencyOne.Helpers
{
    public static class DynamoDbHelper
    {
        public static CreateTableRequest GenerateCreateTableRequest()
        {
            var keySchemaElements = new List<KeySchemaElement>
            {
                new KeySchemaElement
                {
                    AttributeName = "Creator",
                    KeyType = KeyType.HASH
                },
                new KeySchemaElement
                {
                    AttributeName = "TaskName",
                    KeyType = KeyType.RANGE
                }
            };

            var attributeDefinitions = new List<AttributeDefinition>
            {
                new AttributeDefinition
                {
                    AttributeName = "Creator",
                    AttributeType = ScalarAttributeType.S
                },
                new AttributeDefinition
                {
                    AttributeName = "TaskName",
                    AttributeType = ScalarAttributeType.S
                }
            };

            var provisionedThroughput = new ProvisionedThroughput(5, 5);

            return new CreateTableRequest("TaskItems", keySchemaElements, attributeDefinitions, provisionedThroughput);
        }
    }
}
