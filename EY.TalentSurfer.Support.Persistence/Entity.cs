namespace EY.TalentSurfer.Support.Persistence
{
    public class Entity : IEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}
