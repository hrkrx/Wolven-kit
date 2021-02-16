using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ConditionalSegmentBegin_ : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("condition")] public animConditionalSegmentCondition Condition { get; set; }

		public animAnimNode_ConditionalSegmentBegin_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
