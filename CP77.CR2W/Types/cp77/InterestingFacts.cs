using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InterestingFacts : CVariable
	{
		[Ordinal(0)] [RED("zone")] public CName Zone { get; set; }

		public InterestingFacts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
