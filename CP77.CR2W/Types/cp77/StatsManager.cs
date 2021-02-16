using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatsManager : IScriptable
	{
		[Ordinal(0)] [RED("playerGodModeModifierData")] public CHandle<gameStatModifierData> PlayerGodModeModifierData { get; set; }

		public StatsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
