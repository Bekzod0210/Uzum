namespace Uzum.Aplication.Exceptions
{
    public class RegisterException : Exception
    {
        private const string _message = "Register is wrong";

        public RegisterException() : base(_message) { }

        public RegisterException(Exception exception) : base(_message, exception) { }
    }
}
