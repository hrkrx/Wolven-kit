using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionVector_ : animAnimNode_VectorValue
	{
		[Ordinal(1)] [RED("expressionData")] public animMathExpressionNodeData ExpressionData { get; set; }

		public animAnimNode_MathExpressionVector_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
