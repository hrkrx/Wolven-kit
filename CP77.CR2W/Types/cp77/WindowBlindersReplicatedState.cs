using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WindowBlindersReplicatedState : gameDeviceReplicatedState
	{
		[Ordinal(0)] [RED("isOpen")] public CBool IsOpen { get; set; }
		[Ordinal(1)] [RED("isTilted")] public CBool IsTilted { get; set; }

		public WindowBlindersReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
