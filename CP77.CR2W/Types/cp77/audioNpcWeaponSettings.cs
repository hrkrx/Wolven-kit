using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioNpcWeaponSettings : audioWeaponSettings
	{
		[Ordinal(0)]  [RED("gunChoir")] public CName GunChoir { get; set; }
		[Ordinal(1)]  [RED("tails")] public CName Tails { get; set; }
		[Ordinal(2)]  [RED("obstructionEnabled")] public CBool ObstructionEnabled { get; set; }
		[Ordinal(3)]  [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
		[Ordinal(4)]  [RED("repositionEnabled")] public CBool RepositionEnabled { get; set; }
		[Ordinal(5)]  [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }
		[Ordinal(6)]  [RED("disablePathfinding")] public CBool DisablePathfinding { get; set; }
		[Ordinal(7)]  [RED("voiceSwitchCooldown")] public CFloat VoiceSwitchCooldown { get; set; }
		[Ordinal(8)]  [RED("reloadSound")] public CName ReloadSound { get; set; }
		[Ordinal(9)]  [RED("quickMeleeAttackSound")] public CName QuickMeleeAttackSound { get; set; }
		[Ordinal(10)]  [RED("quickMeleeHitSound")] public CName QuickMeleeHitSound { get; set; }

		public audioNpcWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
