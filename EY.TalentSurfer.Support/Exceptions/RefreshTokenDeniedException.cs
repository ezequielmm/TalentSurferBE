using System;

namespace EY.TalentSurfer.Support.Exceptions
{
    public class RefreshTokenDeniedException : Exception
    {
        public RefreshTokenDeniedException(string message) : base(message)
        {
        }
    }
}
