using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DoorTerminalMasterInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		[Ordinal(18)] [RED("currentlyActiveDevices")] public CArray<gamePersistentID> CurrentlyActiveDevices { get; set; }

		public DoorTerminalMasterInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
