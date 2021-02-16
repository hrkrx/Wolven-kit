using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDynamicCookedDeviceData : gameCookedDeviceData
	{
		[Ordinal(4)] [RED("componentName")] public CName ComponentName { get; set; }

		public gameDynamicCookedDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
