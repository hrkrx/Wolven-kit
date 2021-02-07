using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questIJournal_NodeType : questIRetNodeType
	{
		[Ordinal(0)]  [RED("path")] public CHandle<gameJournalPath> Path { get; set; }

		public questIJournal_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
