using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questvehicleToNodeParams : questVehicleSpecificCommandParams
	{
		[Ordinal(0)]  [RED("stopAtEnd")] public CBool StopAtEnd { get; set; }
		[Ordinal(1)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(2)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(3)]  [RED("useTraffic")] public CBool UseTraffic { get; set; }
		[Ordinal(4)]  [RED("speedInTraffic")] public CFloat SpeedInTraffic { get; set; }
		[Ordinal(5)]  [RED("forceGreenLights")] public CBool ForceGreenLights { get; set; }
		[Ordinal(6)]  [RED("portals")] public CHandle<vehiclePortalsList> Portals { get; set; }
		[Ordinal(7)]  [RED("trafficTryNeighborsForStart")] public CBool TrafficTryNeighborsForStart { get; set; }
		[Ordinal(8)]  [RED("trafficTryNeighborsForEnd")] public CBool TrafficTryNeighborsForEnd { get; set; }

		public questvehicleToNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
