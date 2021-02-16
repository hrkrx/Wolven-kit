using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AITimeoutCondition : AITimeCondition
	{
		[Ordinal(0)] [RED("timestamp")] public CFloat Timestamp { get; set; }

		public AITimeoutCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
