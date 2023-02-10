namespace Uzum.Aplication.Exceptions
{
    public class MerchantException : Exception
    {
        private const string _message = "Merchant not found";
        public MerchantException() : base(_message) { }

        public MerchantException(Exception exception) : base(_message, exception) { }
    }
}
