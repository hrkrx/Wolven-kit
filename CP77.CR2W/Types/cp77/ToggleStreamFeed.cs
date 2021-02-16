using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleStreamFeed : ActionBool
	{
		[Ordinal(25)] [RED("vRoomFake")] public CBool VRoomFake { get; set; }

		public ToggleStreamFeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
