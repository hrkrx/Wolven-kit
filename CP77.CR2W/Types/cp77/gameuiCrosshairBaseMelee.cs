using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCrosshairBaseMelee : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("meleeStateBlackboardId")] public CUInt32 MeleeStateBlackboardId { get; set; }
		[Ordinal(19)] [RED("playerSMBB")] public CHandle<gameIBlackboard> PlayerSMBB { get; set; }

		public gameuiCrosshairBaseMelee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
