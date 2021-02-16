using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EnumSwitch : animAnimNode_InputSwitch
	{
		[Ordinal(8)] [RED("enumName")] public CName EnumName { get; set; }

		public animAnimNode_EnumSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
