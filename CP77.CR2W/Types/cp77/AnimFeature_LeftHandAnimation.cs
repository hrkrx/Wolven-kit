using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LeftHandAnimation : animAnimFeature
	{
		[Ordinal(0)] [RED("lockLeftHandAnimation")] public CBool LockLeftHandAnimation { get; set; }

		public AnimFeature_LeftHandAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
