using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeescalationEvent : redEvent
	{
		[Ordinal(0)] [RED("originalNotification")] public CHandle<SecuritySystemInput> OriginalNotification { get; set; }

		public DeescalationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
