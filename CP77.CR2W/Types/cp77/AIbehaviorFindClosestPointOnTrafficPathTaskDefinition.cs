using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindClosestPointOnTrafficPathTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("enterClosest")] public CHandle<AIArgumentMapping> EnterClosest { get; set; }
		[Ordinal(1)]  [RED("avoidedPosition")] public CHandle<AIArgumentMapping> AvoidedPosition { get; set; }
		[Ordinal(2)]  [RED("avoidedPositionDistance")] public CHandle<AIArgumentMapping> AvoidedPositionDistance { get; set; }
		[Ordinal(3)]  [RED("usePreviousPosition")] public CHandle<AIArgumentMapping> UsePreviousPosition { get; set; }
		[Ordinal(4)]  [RED("checkRoadIntersection")] public CHandle<AIArgumentMapping> CheckRoadIntersection { get; set; }
		[Ordinal(5)]  [RED("positionOnPath")] public CHandle<AIArgumentMapping> PositionOnPath { get; set; }
		[Ordinal(6)]  [RED("pathDirection")] public CHandle<AIArgumentMapping> PathDirection { get; set; }
		[Ordinal(7)]  [RED("joinTrafficSettings")] public CHandle<AIArgumentMapping> JoinTrafficSettings { get; set; }

		public AIbehaviorFindClosestPointOnTrafficPathTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
