using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GraphSlotConditions : animAnimNode_GraphSlot
	{
		[Ordinal(4)] [RED("conditions")] public CArray<animGraphSlotCondition> Conditions { get; set; }

		public animAnimNode_GraphSlotConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
