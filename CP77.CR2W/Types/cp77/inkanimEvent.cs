using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimEvent : IScriptable
	{
		[Ordinal(0)] [RED("startTime")] public CFloat StartTime { get; set; }

		public inkanimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
