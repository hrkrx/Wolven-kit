using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questToggleWindow_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(1)]  [RED("windowState")] public CEnum<vehicleEQuestVehicleWindowState> WindowState { get; set; }
		[Ordinal(2)]  [RED("door")] public CEnum<vehicleEVehicleDoor> Door { get; set; }

		public questToggleWindow_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
