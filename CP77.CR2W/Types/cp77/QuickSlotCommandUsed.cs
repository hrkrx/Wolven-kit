using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickSlotCommandUsed : redEvent
	{
		[Ordinal(0)] [RED("action")] public CHandle<gamedeviceAction> Action { get; set; }

		public QuickSlotCommandUsed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
