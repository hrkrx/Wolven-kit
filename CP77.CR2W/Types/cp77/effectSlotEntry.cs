using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectSlotEntry : CVariable
	{
		[Ordinal(0)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(1)]  [RED("relativePosition")] public Vector3 RelativePosition { get; set; }
		[Ordinal(2)]  [RED("relativeRotation")] public Quaternion RelativeRotation { get; set; }

		public effectSlotEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
