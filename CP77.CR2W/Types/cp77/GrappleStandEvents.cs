using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GrappleStandEvents : LocomotionTakedownEvents
	{
		[Ordinal(1)] [RED("isWalking")] public CBool IsWalking { get; set; }

		public GrappleStandEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
