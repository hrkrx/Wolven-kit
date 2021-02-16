using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AttackSubtypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] [RED("attackSubtype")] public CEnum<gamedataAttackSubtype> AttackSubtype { get; set; }

		public AttackSubtypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
