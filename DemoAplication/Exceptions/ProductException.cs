namespace Uzum.Aplication.Exceptions
{
    public class ProductException : Exception
    {
        private const string _message = "Product not found";
        public ProductException() : base(_message) { }

        public ProductException(Exception exception) : base(_message, exception) { }

    }
}
