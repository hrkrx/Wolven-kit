using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeSharedVarsDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		[Ordinal(1)] [RED("sharedVars")] public AISharedVarTableDefinition SharedVars { get; set; }

		public AICTreeNodeSharedVarsDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
