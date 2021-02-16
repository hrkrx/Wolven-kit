using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerksSkillLabelContentContainer : HubMenuLabelContentContainer
	{
		[Ordinal(8)] [RED("levelLabel")] public inkTextWidgetReference LevelLabel { get; set; }
		[Ordinal(9)] [RED("levelBar")] public inkWidgetReference LevelBar { get; set; }
		[Ordinal(10)] [RED("skillData")] public CHandle<ProficiencyDisplayData> SkillData { get; set; }

		public PerksSkillLabelContentContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
