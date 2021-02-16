using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questFinalBoardsEnableSkipCredits_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("enableSkipping")] public CBool EnableSkipping { get; set; }

		public questFinalBoardsEnableSkipCredits_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
