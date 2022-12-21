namespace DOGAN.AmbarStokTakip.Core.Utilities.Result
{
    public interface IResult
    {
        bool IsSuccess { get; }
        string Message { get; }
        long Id { get; }
    }
}
