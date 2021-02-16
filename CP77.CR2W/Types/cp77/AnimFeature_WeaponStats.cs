using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponStats : animAnimFeature
	{
		[Ordinal(0)] [RED("magazineCapacity")] public CInt32 MagazineCapacity { get; set; }
		[Ordinal(1)] [RED("cycleTime")] public CFloat CycleTime { get; set; }

		public AnimFeature_WeaponStats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
