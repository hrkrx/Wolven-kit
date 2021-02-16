using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TeleportDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("teleport")] public STeleportOperationData Teleport { get; set; }

		public TeleportDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
