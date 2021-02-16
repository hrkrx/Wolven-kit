using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkHighwaySignLogicController : inkIStreetNameSignLogicController
	{
		[Ordinal(1)] [RED("districtName")] public inkTextWidgetReference DistrictName { get; set; }
		[Ordinal(2)] [RED("subDistrictName")] public inkTextWidgetReference SubDistrictName { get; set; }
		[Ordinal(3)] [RED("metroStationIconLeft")] public inkImageWidgetReference MetroStationIconLeft { get; set; }
		[Ordinal(4)] [RED("metroStationIconRight")] public inkImageWidgetReference MetroStationIconRight { get; set; }

		public inkHighwaySignLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
