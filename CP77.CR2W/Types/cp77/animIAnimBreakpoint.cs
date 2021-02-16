using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animIAnimBreakpoint : CVariable
	{
		[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }

		public animIAnimBreakpoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
