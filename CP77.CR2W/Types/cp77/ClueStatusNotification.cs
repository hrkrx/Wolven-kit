using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ClueStatusNotification : HUDManagerRequest
	{
		[Ordinal(1)] [RED("isClue")] public CBool IsClue { get; set; }
		[Ordinal(2)] [RED("clueGroupID")] public CName ClueGroupID { get; set; }

		public ClueStatusNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
