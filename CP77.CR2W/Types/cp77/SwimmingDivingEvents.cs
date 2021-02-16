using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SwimmingDivingEvents : LocomotionSwimmingEvents
	{
		[Ordinal(0)] [RED("lapsedTime")] public CFloat LapsedTime { get; set; }

		public SwimmingDivingEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
