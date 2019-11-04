using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace EY.TalentSurfer.Support.Exceptions
{
    [Serializable]
    public class UserException : Exception
    {
        private readonly string _message;

        public UserException(string message)
        {
            _message = message;
        }

        public UserException(IEnumerable<string> messages)
        {
            _message = messages.Aggregate((errors, error) => $"{errors}, {error}");
        }

        protected UserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override string Message => _message;
    }
}
