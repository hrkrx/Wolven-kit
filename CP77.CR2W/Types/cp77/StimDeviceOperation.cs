using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StimDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] [RED("stims")] public CArray<SStimOperationData> Stims { get; set; }

		public StimDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
