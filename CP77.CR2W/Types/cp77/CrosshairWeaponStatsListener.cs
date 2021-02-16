using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairWeaponStatsListener : gameScriptStatsListener
	{
		[Ordinal(0)] [RED("controller")] public wCHandle<BaseTechCrosshairController> Controller { get; set; }

		public CrosshairWeaponStatsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
