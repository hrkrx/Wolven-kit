using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayTooltipController : AGenericTooltipController
	{
		[Ordinal(0)]  [RED("data")] public CHandle<BasePerksMenuTooltipData> Data { get; set; }
		[Ordinal(1)]  [RED("holdToUpgradeHint")] public inkWidgetReference HoldToUpgradeHint { get; set; }
		[Ordinal(2)]  [RED("levelDescriptionText")] public inkTextWidgetReference LevelDescriptionText { get; set; }
		[Ordinal(3)]  [RED("levelText")] public inkTextWidgetReference LevelText { get; set; }
		[Ordinal(4)]  [RED("nextLevelDescriptionText")] public inkTextWidgetReference NextLevelDescriptionText { get; set; }
		[Ordinal(5)]  [RED("nextLevelText")] public inkTextWidgetReference NextLevelText { get; set; }
		[Ordinal(6)]  [RED("nextLevelWrapper")] public inkWidgetReference NextLevelWrapper { get; set; }
		[Ordinal(7)]  [RED("perkNameText")] public inkTextWidgetReference PerkNameText { get; set; }
		[Ordinal(8)]  [RED("perkTypeText")] public inkTextWidgetReference PerkTypeText { get; set; }
		[Ordinal(9)]  [RED("perkTypeWrapper")] public inkWidgetReference PerkTypeWrapper { get; set; }
		[Ordinal(10)]  [RED("root")] public new inkWidgetReference Root { get; set; }
		[Ordinal(11)]  [RED("traitLevelGrowthText")] public inkTextWidgetReference TraitLevelGrowthText { get; set; }
		[Ordinal(12)]  [RED("unlockInfoWrapper")] public inkWidgetReference UnlockInfoWrapper { get; set; }
		[Ordinal(13)]  [RED("unlockPerkWrapper")] public inkWidgetReference UnlockPerkWrapper { get; set; }
		[Ordinal(14)]  [RED("unlockPointsDesc")] public inkTextWidgetReference UnlockPointsDesc { get; set; }
		[Ordinal(15)]  [RED("unlockPointsText")] public inkTextWidgetReference UnlockPointsText { get; set; }
		[Ordinal(16)]  [RED("unlockStateText")] public inkTextWidgetReference UnlockStateText { get; set; }
		[Ordinal(17)]  [RED("unlockTraitPointsText")] public inkTextWidgetReference UnlockTraitPointsText { get; set; }
		[Ordinal(18)]  [RED("unlockTraitWrapper")] public inkWidgetReference UnlockTraitWrapper { get; set; }
		[Ordinal(19)]  [RED("videoWidget")] public inkVideoWidgetReference VideoWidget { get; set; }
		[Ordinal(20)]  [RED("videoWrapper")] public inkWidgetReference VideoWrapper { get; set; }

		public PerkDisplayTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
