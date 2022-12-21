namespace DOGAN.AmbarStokTakip.Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool success)
        {
            IsSuccess = success;
        }
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public Result(bool success, long id):this(success)
        {
            Id = id;
        }
        public bool IsSuccess { get; }

        public string Message { get; }

        public long Id { get; }
    }
}
