using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleRequestCameraPerspectiveEvent : redEvent
	{
		[Ordinal(0)] [RED("cameraPerspective")] public CEnum<vehicleCameraPerspective> CameraPerspective { get; set; }

		public vehicleRequestCameraPerspectiveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
