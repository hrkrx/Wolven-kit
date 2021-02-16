using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckStimTag : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("stimTagToCompare")] public CArray<CName> StimTagToCompare { get; set; }

		public CheckStimTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
