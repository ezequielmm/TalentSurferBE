namespace EY.TalentSurfer.Support.Persistence
{
    public interface IEntity
    {
        int Id { get; }
        bool Deleted { get; set; }
    }
}
