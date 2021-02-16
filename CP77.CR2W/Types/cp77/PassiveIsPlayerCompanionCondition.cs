using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PassiveIsPlayerCompanionCondition : PassiveAutonomousCondition
	{
		[Ordinal(0)] [RED("roleCbId")] public CUInt32 RoleCbId { get; set; }

		public PassiveIsPlayerCompanionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
