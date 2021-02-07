using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTransformAnimatorNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(2)]  [RED("action")] public CHandle<questTransformAnimatorNode_ActionType> Action { get; set; }

		public questTransformAnimatorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
