using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVehicleSpeed_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(1)] [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(2)] [RED("comparisonType")] public CEnum<vehicleEVehicleSpeedConditionType> ComparisonType { get; set; }

		public questVehicleSpeed_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
