using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionAnimationCurvePathDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(0)]  [RED("nodeReference")] public LibTreeDefNodeRef NodeReference { get; set; }
		[Ordinal(1)]  [RED("controllersSetupName")] public LibTreeDefCName ControllersSetupName { get; set; }
		[Ordinal(2)]  [RED("useStart")] public LibTreeDefBool UseStart { get; set; }
		[Ordinal(3)]  [RED("useStop")] public LibTreeDefBool UseStop { get; set; }
		[Ordinal(4)]  [RED("blendTime")] public LibTreeDefFloat BlendTime { get; set; }
		[Ordinal(5)]  [RED("globalInBlendTime")] public LibTreeDefFloat GlobalInBlendTime { get; set; }
		[Ordinal(6)]  [RED("globalOutBlendTime")] public LibTreeDefFloat GlobalOutBlendTime { get; set; }
		[Ordinal(7)]  [RED("turnCharacterToMatchVelocity")] public LibTreeDefBool TurnCharacterToMatchVelocity { get; set; }
		[Ordinal(8)]  [RED("customStartAnimationName")] public LibTreeDefCName CustomStartAnimationName { get; set; }
		[Ordinal(9)]  [RED("customMainAnimationName")] public LibTreeDefCName CustomMainAnimationName { get; set; }
		[Ordinal(10)]  [RED("customStopAnimationName")] public LibTreeDefCName CustomStopAnimationName { get; set; }
		[Ordinal(11)]  [RED("startSnapToTerrain")] public LibTreeDefBool StartSnapToTerrain { get; set; }
		[Ordinal(12)]  [RED("mainSnapToTerrain")] public LibTreeDefBool MainSnapToTerrain { get; set; }
		[Ordinal(13)]  [RED("stopSnapToTerrain")] public LibTreeDefBool StopSnapToTerrain { get; set; }
		[Ordinal(14)]  [RED("startSnapToTerrainBlendTime")] public LibTreeDefFloat StartSnapToTerrainBlendTime { get; set; }
		[Ordinal(15)]  [RED("stopSnapToTerrainBlendTime")] public LibTreeDefFloat StopSnapToTerrainBlendTime { get; set; }

		public AICTreeNodeActionAnimationCurvePathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
