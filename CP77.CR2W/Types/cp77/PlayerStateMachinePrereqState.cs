using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerStateMachinePrereqState : gamePrereqState
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)] [RED("listenerInt")] public CUInt32 ListenerInt { get; set; }
		[Ordinal(2)] [RED("prevValue")] public CInt32 PrevValue { get; set; }

		public PlayerStateMachinePrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
