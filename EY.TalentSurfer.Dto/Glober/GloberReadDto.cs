using System.Collections.Generic;

namespace EY.TalentSurfer.Dto
{
    public class GloberReadDto
    {
        public List<Glober> globers { get; set; }
    }
    public class Glober
    {
        public List<string> globerName { get; set; }
        public string seniority { get; set; }
        public string position { get; set; }
        public string email { get; set; }
        public string location { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public object phone { get; set; }
        public string familyGroup { get; set; }
    }
}
