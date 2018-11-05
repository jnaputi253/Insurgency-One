namespace InsurgencyOne.Results
{
    public interface IResult
    {
        bool IsSuccessful { get; }

        string ErrorMessage { get; }
    }
}
