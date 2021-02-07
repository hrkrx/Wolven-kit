using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEdgeConditionDefinition : AIbehaviorUnaryConditionDefinition
	{
		[Ordinal(0)]  [RED("risingEdgeAction")] public CEnum<AIbehaviorEdgeConditionAction> RisingEdgeAction { get; set; }
		[Ordinal(1)]  [RED("fallingEdgeAction")] public CEnum<AIbehaviorEdgeConditionAction> FallingEdgeAction { get; set; }
		[Ordinal(2)]  [RED("initialValue")] public CBool InitialValue { get; set; }

		public AIbehaviorEdgeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
