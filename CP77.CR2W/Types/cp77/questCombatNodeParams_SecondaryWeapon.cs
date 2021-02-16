using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_SecondaryWeapon : questCombatNodeParams
	{
		[Ordinal(0)] [RED("unEquip")] public CBool UnEquip { get; set; }

		public questCombatNodeParams_SecondaryWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
