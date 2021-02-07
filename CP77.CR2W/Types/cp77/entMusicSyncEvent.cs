using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entMusicSyncEvent : redEvent
	{
		[Ordinal(0)]  [RED("syncType")] public CEnum<audioMusicSyncType> SyncType { get; set; }
		[Ordinal(1)]  [RED("syncParameter")] public CFloat SyncParameter { get; set; }

		public entMusicSyncEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
