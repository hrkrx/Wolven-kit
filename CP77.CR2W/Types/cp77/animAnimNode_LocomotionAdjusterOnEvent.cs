using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionAdjusterOnEvent : animAnimNode_LocomotionAdjuster
	{
		[Ordinal(9)] [RED("locomotionFeatureName")] public CName LocomotionFeatureName { get; set; }
		[Ordinal(10)] [RED("targetAnimationName")] public CName TargetAnimationName { get; set; }
		[Ordinal(11)] [RED("startAdjustmentAfterAnimEvent")] public CName StartAdjustmentAfterAnimEvent { get; set; }

		public animAnimNode_LocomotionAdjusterOnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
