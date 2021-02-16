using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TagStatusNotification : HUDManagerRequest
	{
		[Ordinal(1)] [RED("isTagged")] public CBool IsTagged { get; set; }

		public TagStatusNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
