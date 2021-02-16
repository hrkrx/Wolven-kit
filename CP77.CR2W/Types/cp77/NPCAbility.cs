using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCAbility : CVariable
	{
		[Ordinal(0)] [RED("abilityName")] public CString AbilityName { get; set; }

		public NPCAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
