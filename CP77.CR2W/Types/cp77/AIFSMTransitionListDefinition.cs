using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFSMTransitionListDefinition : CVariable
	{
		[Ordinal(0)] [RED("firstTransitionIndex")] public CUInt16 FirstTransitionIndex { get; set; }
		[Ordinal(1)] [RED("transitionsCount")] public CUInt16 TransitionsCount { get; set; }

		public AIFSMTransitionListDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
