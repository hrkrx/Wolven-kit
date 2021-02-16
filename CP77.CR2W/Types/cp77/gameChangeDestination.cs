using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameChangeDestination : gameActionInternalEvent
	{
		[Ordinal(0)] [RED("destination")] public Vector4 Destination { get; set; }

		public gameChangeDestination(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
