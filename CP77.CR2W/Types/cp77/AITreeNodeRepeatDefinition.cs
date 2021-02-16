using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AITreeNodeRepeatDefinition : AICTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("limit")] public LibTreeDefInt32 Limit { get; set; }

		public AITreeNodeRepeatDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
