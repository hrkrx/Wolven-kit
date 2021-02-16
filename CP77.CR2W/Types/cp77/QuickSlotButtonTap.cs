using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickSlotButtonTap : redEvent
	{
		[Ordinal(0)] [RED("dPadItemDirection")] public CEnum<EDPadSlot> DPadItemDirection { get; set; }

		public QuickSlotButtonTap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
