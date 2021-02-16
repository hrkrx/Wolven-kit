using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAttitudeAgentPS : gameComponentPS
	{
		[Ordinal(0)] [RED("currentAttitudeGroup")] public CName CurrentAttitudeGroup { get; set; }

		public gameAttitudeAgentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
