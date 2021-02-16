using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationSummaryListItemData : IScriptable
	{
		[Ordinal(0)] [RED("label")] public CString Label { get; set; }
		[Ordinal(1)] [RED("desc")] public CString Desc { get; set; }

		public CharacterCreationSummaryListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
