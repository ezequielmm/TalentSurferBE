using System.Collections.Generic;

namespace EY.TalentSurfer.Dto
{
    public class GloberReadDto
    {
        public List<Glober> Globers { get; set; }
    }
    public class Glober
    {
        public List<string> GloberName { get; set; }
        public string Seniority { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public object Phone { get; set; }
        public string FamilyGroup { get; set; }
    }
}
