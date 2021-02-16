using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LootContainerObjectAnimatedByTransform : gameContainerObjectBase
	{
		[Ordinal(51)] [RED("wasOpened")] public CBool WasOpened { get; set; }

		public LootContainerObjectAnimatedByTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
