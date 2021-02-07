using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCreditsSectionEntry : CVariable
	{
		[Ordinal(0)]  [RED("sectionTitle")] public CString SectionTitle { get; set; }
		[Ordinal(1)]  [RED("names")] public CArray<CString> Names { get; set; }
		[Ordinal(2)]  [RED("displayMode")] public CEnum<inkDisplayMode> DisplayMode { get; set; }

		public inkCreditsSectionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
