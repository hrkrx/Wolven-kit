using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIStackSignalCondition : AIbehaviorStackScriptPassiveExpressionDefinition
	{
		[Ordinal(0)] [RED("signalName")] public CName SignalName { get; set; }

		public AIStackSignalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
