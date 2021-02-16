using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DisableSleepMode : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("forceUpdate")] public CBool ForceUpdate { get; set; }

		public animAnimNode_DisableSleepMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
