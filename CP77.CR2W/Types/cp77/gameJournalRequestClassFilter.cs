using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalRequestClassFilter : CVariable
	{
		[Ordinal(0)] [RED("className")] public CName ClassName { get; set; }

		public gameJournalRequestClassFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
