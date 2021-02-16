using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PassivePatrolConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] [RED("roleCbId")] public CUInt32 RoleCbId { get; set; }
		[Ordinal(1)] [RED("cmdCbId")] public CUInt32 CmdCbId { get; set; }

		public PassivePatrolConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
