using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TerminalSetState : redEvent
	{
		[Ordinal(0)] [RED("state")] public CEnum<gameinteractionsReactionState> State { get; set; }

		public TerminalSetState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
