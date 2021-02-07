using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLootSlot : gameLootContainerBase
	{
		[Ordinal(0)]  [RED("immovableAfterDrop")] public CBool ImmovableAfterDrop { get; set; }
		[Ordinal(1)]  [RED("dropChance")] public CFloat DropChance { get; set; }
		[Ordinal(2)]  [RED("lootState")] public CEnum<gameLootSlotState> LootState { get; set; }

		public gameLootSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
