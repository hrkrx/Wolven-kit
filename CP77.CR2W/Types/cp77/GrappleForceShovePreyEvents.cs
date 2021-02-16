using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GrappleForceShovePreyEvents : LocomotionTakedownEvents
	{
		[Ordinal(1)] [RED("unmountCalled")] public CBool UnmountCalled { get; set; }

		public GrappleForceShovePreyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
