using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Domain
{
    public class Position : AuditableEntity
    {
        private readonly IUserProvider _userProvider;
        private readonly IDateTimeProvider _dateTimeProvider;

        public Position()
        {
        }

        public Position(IUserProvider userProvider, IDateTimeProvider dateTimeProvider)
        {
            _userProvider = userProvider;
            _dateTimeProvider = dateTimeProvider;
            CreatedBy = _userProvider.Email ?? _userProvider.AppId;
            CreatedOn = _dateTimeProvider.Now;
        }

        public int SortOrder { get; set; }
        public string Description { get; set; }
        public bool ArchivingFlag { get; set; }
        public string Comments { get; set; }
    }
}
