using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LadderEvents : LocomotionGroundEvents
	{
		[Ordinal(0)] [RED("ladderClimbCameraTimeStamp")] public CFloat LadderClimbCameraTimeStamp { get; set; }

		public LadderEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
