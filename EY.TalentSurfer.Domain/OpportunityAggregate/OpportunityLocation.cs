namespace EY.TalentSurfer.Domain
{
    public class OpportunityLocation
    {
        public Opportunity Opportunity { get; set; }
        public int OpportunityId { get; set; }

        public Location Location { get; set; }
        public int LocationId { get; set; }

        protected OpportunityLocation()
        {
        }

        public OpportunityLocation(int opportunityId, int locationId)
        {
            OpportunityId = opportunityId;
            LocationId = locationId;
        }
    }
}
