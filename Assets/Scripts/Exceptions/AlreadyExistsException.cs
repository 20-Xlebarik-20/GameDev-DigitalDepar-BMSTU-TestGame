using System;


namespace LearnGame.Exceptions
{
    internal class AlreadyExistsException : Exception
    {
        private const string BaseMessage = "This element already in collection!";
        
        public AlreadyExistsException(): base(BaseMessage) { }

        public AlreadyExistsException(string message) : base(message) { }

        public AlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }
    }
}
