using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalSharedStateData : CVariable
	{
		[Ordinal(0)]  [RED("pathHash")] public CUInt32 PathHash { get; set; }
		[Ordinal(1)]  [RED("entryState")] public CEnum<gameJournalEntryState> EntryState { get; set; }

		public gameJournalSharedStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
