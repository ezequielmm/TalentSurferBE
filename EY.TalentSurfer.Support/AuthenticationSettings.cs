namespace EY.TalentSurfer.Support
{
    public class AuthenticationSettings
    {
        public string Secret { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string ReturnUrl { get; set; }
        public double TokenDuration { get; set; }
    }
}
