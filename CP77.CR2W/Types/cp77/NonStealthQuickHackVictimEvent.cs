using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NonStealthQuickHackVictimEvent : redEvent
	{
		[Ordinal(0)] [RED("instigatorID")] public entEntityID InstigatorID { get; set; }

		public NonStealthQuickHackVictimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
