using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class State : MorphData
	{
		[Ordinal(1)] [RED("state")] public CEnum<ESecuritySystemState> State_ { get; set; }

		public State(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
