using System;

namespace EY.TalentSurfer.Support
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
    }
}