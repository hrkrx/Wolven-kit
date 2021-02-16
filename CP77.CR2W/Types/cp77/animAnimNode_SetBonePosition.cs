using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetBonePosition : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(3)] [RED("positionMs")] public animVectorLink PositionMs { get; set; }

		public animAnimNode_SetBonePosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
