using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StackTransformsShrinker : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("tag")] public CName Tag { get; set; }

        [Ordinal(999)] [RED("extenderNodeId")] public CUInt32 extenderNodeId { get; set; }

		public animAnimNode_StackTransformsShrinker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
