using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NewBackdoorDeviceRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("device")] public CHandle<ScriptableDeviceComponentPS> Device { get; set; }

		public NewBackdoorDeviceRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
