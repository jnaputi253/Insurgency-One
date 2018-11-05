namespace InsurgencyOne.Results
{
    public class CreateTableResult : IResult
    {
        public bool IsSuccessful { get; }

        public string ErrorMessage { get; }

        public CreateTableResult(bool isSuccessful, string errorMessage)
        {
            IsSuccessful = isSuccessful;
            ErrorMessage = errorMessage;
        }
    }
}
