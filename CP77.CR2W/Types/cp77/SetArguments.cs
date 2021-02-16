using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetArguments : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("argumentVar")] public CName ArgumentVar { get; set; }

		public SetArguments(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
