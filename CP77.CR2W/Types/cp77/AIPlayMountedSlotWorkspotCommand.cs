using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIPlayMountedSlotWorkspotCommand : AICommand
	{
		[Ordinal(4)] [RED("mountData")] public gameMountDescriptor MountData { get; set; }

		public AIPlayMountedSlotWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
