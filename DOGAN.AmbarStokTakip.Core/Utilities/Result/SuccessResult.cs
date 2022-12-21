namespace DOGAN.AmbarStokTakip.Core.Utilities.Result
{
    public class SuccessResult:Result
    {
        public SuccessResult():base(true)
        {

        }
        public SuccessResult(string message):base(true,message)
        {

        }
        public SuccessResult(long id):base(true,id)
        {

        }
    }
}
