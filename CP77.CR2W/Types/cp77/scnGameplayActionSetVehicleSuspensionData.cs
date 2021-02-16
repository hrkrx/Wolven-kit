using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnGameplayActionSetVehicleSuspensionData : scnIGameplayActionData
	{
		[Ordinal(0)] [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)] [RED("cooldownTime")] public CFloat CooldownTime { get; set; }

		public scnGameplayActionSetVehicleSuspensionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
