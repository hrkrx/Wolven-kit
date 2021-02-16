using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questOpenBriefing_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("briefingPath")] public CHandle<gameJournalPath> BriefingPath { get; set; }

		public questOpenBriefing_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
