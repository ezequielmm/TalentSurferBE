using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Domain
{
    public class PositionSlotLocation
    {
        public int PositionSlotId { get; protected set; }
        public int LocationId { get; protected set; }
        public PositionSlot PositionSlot { get;protected set; }
        public Location Location { get; protected set; }
        private PositionSlotLocation()
        {
        }

        public PositionSlotLocation(int positionSlotId, int locationId)
        {
            PositionSlotId = positionSlotId;
            LocationId = locationId;
        }

    }
}
