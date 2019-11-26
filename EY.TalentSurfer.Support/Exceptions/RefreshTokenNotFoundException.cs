using System;

namespace EY.TalentSurfer.Support.Exceptions
{
    public class RefreshTokenNotFoundException : Exception
    {
        public RefreshTokenNotFoundException(string message) : base(message)
        {
        }
    }
}