using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionTeleportToNodeDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(0)]  [RED("nodeRef")] public LibTreeDefNodeRef NodeRef { get; set; }
		[Ordinal(1)]  [RED("offset")] public LibTreeDefVector Offset { get; set; }
		[Ordinal(2)]  [RED("doNavTest")] public CBool DoNavTest { get; set; }

		public AICTreeNodeActionTeleportToNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
