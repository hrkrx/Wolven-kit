using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SToggleDeviceOperationData : CVariable
	{
		[Ordinal(0)] [RED("operationName")] public CName OperationName { get; set; }
		[Ordinal(1)] [RED("enable")] public CBool Enable { get; set; }

		public SToggleDeviceOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
