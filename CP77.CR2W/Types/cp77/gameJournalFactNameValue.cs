using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalFactNameValue : CVariable
	{
		[Ordinal(0)] [RED("factName")] public CName FactName { get; set; }
		[Ordinal(1)] [RED("factValue")] public CInt32 FactValue { get; set; }

		public gameJournalFactNameValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
