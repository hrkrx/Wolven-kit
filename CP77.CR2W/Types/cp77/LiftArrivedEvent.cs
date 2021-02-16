using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LiftArrivedEvent : redEvent
	{
		[Ordinal(0)] [RED("floor")] public CString Floor { get; set; }

		public LiftArrivedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
