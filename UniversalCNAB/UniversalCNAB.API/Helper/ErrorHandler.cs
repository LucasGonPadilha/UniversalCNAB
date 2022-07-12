namespace UniversalCNAB.API.Helper
{
    public class ErrorHandler
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string InnerMessage { get; set; }

        public ErrorHandler Catch(Exception ex)
        {
            return new ErrorHandler()
            {
                Code = 0,
                Message = ex.Message,
                InnerMessage = ex.InnerException?.Message
            };
        }
    }
}
