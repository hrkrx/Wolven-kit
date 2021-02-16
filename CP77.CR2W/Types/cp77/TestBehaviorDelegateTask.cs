using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TestBehaviorDelegateTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("attrRef")] public AIbehaviorDelegateAttrRef AttrRef { get; set; }
		[Ordinal(1)] [RED("taskRef")] public AIbehaviorDelegateTaskRef TaskRef { get; set; }

		public TestBehaviorDelegateTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
