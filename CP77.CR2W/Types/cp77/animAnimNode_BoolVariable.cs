using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BoolVariable : animAnimNode_BoolValue
	{
		[Ordinal(1)] [RED("variableName")] public CName VariableName { get; set; }

		public animAnimNode_BoolVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
