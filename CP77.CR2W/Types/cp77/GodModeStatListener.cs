using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GodModeStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] [RED("healthbar")] public CHandle<healthbarWidgetGameController> Healthbar { get; set; }

		public GodModeStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
