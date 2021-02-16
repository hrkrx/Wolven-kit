using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_StimReactions : animAnimFeature
	{
		[Ordinal(0)] [RED("reactionType")] public CInt32 ReactionType { get; set; }

		public AnimFeature_StimReactions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
