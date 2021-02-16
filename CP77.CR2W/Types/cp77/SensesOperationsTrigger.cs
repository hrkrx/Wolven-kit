using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SensesOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] [RED("triggerData")] public CHandle<SensesOperationTriggerData> TriggerData { get; set; }

		public SensesOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
