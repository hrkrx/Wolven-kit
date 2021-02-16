using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDebugFailsafeConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("logMessage")] public CHandle<AIArgumentMapping> LogMessage { get; set; }

		public AIbehaviorDebugFailsafeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
