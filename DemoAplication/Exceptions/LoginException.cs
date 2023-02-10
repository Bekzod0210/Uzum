namespace Uzum.Aplication.Exceptions
{
    public class LoginException : Exception
    {
        private const string _message = "UserName or Password is wrong";
        public LoginException() : base(_message) { }
        public LoginException(Exception exception) : base(_message, exception) { }
    }
}
