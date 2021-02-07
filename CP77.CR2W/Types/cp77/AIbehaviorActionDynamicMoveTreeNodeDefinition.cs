using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionDynamicMoveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("moveType")] public CHandle<AIArgumentMapping> MoveType { get; set; }
		[Ordinal(1)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(2)]  [RED("targetPosition")] public CHandle<AIArgumentMapping> TargetPosition { get; set; }
		[Ordinal(3)]  [RED("toleranceRadius")] public CHandle<AIArgumentMapping> ToleranceRadius { get; set; }
		[Ordinal(4)]  [RED("desiredDistanceFromTarget")] public CHandle<AIArgumentMapping> DesiredDistanceFromTarget { get; set; }
		[Ordinal(5)]  [RED("strafingTarget")] public CHandle<AIArgumentMapping> StrafingTarget { get; set; }
		[Ordinal(6)]  [RED("stopWhenDestinationReached")] public CHandle<AIArgumentMapping> StopWhenDestinationReached { get; set; }
		[Ordinal(7)]  [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
		[Ordinal(8)]  [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }

		public AIbehaviorActionDynamicMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
