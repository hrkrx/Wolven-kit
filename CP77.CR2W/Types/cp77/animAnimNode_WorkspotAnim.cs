using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_WorkspotAnim : animAnimNode_Base
	{
		[Ordinal(1)] [RED("collectEvents")] public CBool CollectEvents { get; set; }
		[Ordinal(2)] [RED("inputLink")] public animPoseLink InputLink { get; set; }

		public animAnimNode_WorkspotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
