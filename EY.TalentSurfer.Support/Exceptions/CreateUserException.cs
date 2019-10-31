using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace EY.TalentSurfer.Support.Exceptions
{
    [Serializable]
    public class CreateUserException : Exception
    {
        private readonly IEnumerable<string> _messages;

        public CreateUserException(IEnumerable<string> messages)
        {
            _messages = messages;
        }

        protected CreateUserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override string Message => _messages.Aggregate((errors, error) => $"{errors}, {error}");
    }
}
