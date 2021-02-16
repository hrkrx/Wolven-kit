using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class enteventsEntityResize : redEvent
	{
		[Ordinal(0)] [RED("extents")] public Vector3 Extents { get; set; }

		public enteventsEntityResize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
