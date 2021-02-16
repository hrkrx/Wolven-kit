using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_InputSwitch : animAnimNode_BaseSwitch
	{
		[Ordinal(6)] [RED("selectIntNode")] public animIntLink SelectIntNode { get; set; }
		[Ordinal(7)] [RED("selectFloatNode")] public animFloatLink SelectFloatNode { get; set; }

		public animAnimNode_InputSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
