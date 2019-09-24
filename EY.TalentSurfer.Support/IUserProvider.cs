namespace EY.TalentSurfer.Support
{
    public interface IUserProvider
    {
        string UserName { get; }
        string ObjectId { get; }
        string Email { get; }
        string AppId { get; }
    }
}