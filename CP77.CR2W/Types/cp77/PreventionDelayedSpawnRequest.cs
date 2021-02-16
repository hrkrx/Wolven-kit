using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PreventionDelayedSpawnRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("heatStage")] public CEnum<EPreventionHeatStage> HeatStage { get; set; }

		public PreventionDelayedSpawnRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
