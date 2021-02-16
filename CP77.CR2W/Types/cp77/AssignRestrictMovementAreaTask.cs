using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AssignRestrictMovementAreaTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("restrictMovementAreaRef")] public CHandle<AIArgumentMapping> RestrictMovementAreaRef { get; set; }

		public AssignRestrictMovementAreaTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
