namespace EY.TalentSurfer.Domain
{
    public class OpportunityLocation
    {
        public Opportunity Opportunity { get; protected set; }
        public int OpportunityId { get; protected set; }

        public Location Location { get; protected set; }
        public int LocationId { get; protected set; }

        private OpportunityLocation()
        {
        }

        public OpportunityLocation(int opportunityId, int locationId)
        {
            OpportunityId = opportunityId;
            LocationId = locationId;
        }
    }
}
