using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsStartTakedownEvent : redEvent
	{
		[Ordinal(0)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(1)]  [RED("slideTime")] public CFloat SlideTime { get; set; }

		public gameeventsStartTakedownEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
