using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnlocLocstringId : CVariable
	{
		[Ordinal(0)] [RED("ruid")] public CRUID Ruid { get; set; }

		public scnlocLocstringId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
