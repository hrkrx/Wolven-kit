using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VRoomFeed : redEvent
	{
		[Ordinal(0)] [RED("On")] public CBool On { get; set; }

		public VRoomFeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
