using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareActionAbstractEvents : LeftHandCyberwareEventsTransition
	{
		[Ordinal(0)] [RED("projectileReleased")] public CBool ProjectileReleased { get; set; }

		public LeftHandCyberwareActionAbstractEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
