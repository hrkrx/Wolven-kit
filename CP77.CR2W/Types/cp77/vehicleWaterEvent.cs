using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleWaterEvent : redEvent
	{
		[Ordinal(0)] [RED("isInWater")] public CBool IsInWater { get; set; }

		public vehicleWaterEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
