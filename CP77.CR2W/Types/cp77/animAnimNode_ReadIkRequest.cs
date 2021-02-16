using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ReadIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("ikChain")] public CName IkChain { get; set; }
		[Ordinal(3)] [RED("outTransform")] public animTransformIndex OutTransform { get; set; }

		public animAnimNode_ReadIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
