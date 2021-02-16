using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IconsInstance : ModuleInstance
	{
		[Ordinal(6)] [RED("isForcedVisibleThroughWalls")] public CBool IsForcedVisibleThroughWalls { get; set; }

		public IconsInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
