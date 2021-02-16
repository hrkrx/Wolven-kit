using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UpdateAutoRevealStatEvent : redEvent
	{
		[Ordinal(0)] [RED("hasAutoReveal")] public CBool HasAutoReveal { get; set; }

		public UpdateAutoRevealStatEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
