using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workActorTagCondition : workIWorkspotCondition
	{
		[Ordinal(2)] [RED("tag")] public CName Tag { get; set; }

		public workActorTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
