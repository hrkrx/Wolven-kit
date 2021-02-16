using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AISwitchToPrimaryWeaponCommand : AICommand
	{
		[Ordinal(4)] [RED("unEquip")] public CBool UnEquip { get; set; }

		public AISwitchToPrimaryWeaponCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
