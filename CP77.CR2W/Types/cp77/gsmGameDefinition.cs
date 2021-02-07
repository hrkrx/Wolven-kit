using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gsmGameDefinition : CResource
	{
		[Ordinal(0)]  [RED("mainQuest")] public raRef<questQuestResource> MainQuest { get; set; }
		[Ordinal(1)]  [RED("world")] public raRef<worldWorld> World { get; set; }
		[Ordinal(2)]  [RED("streamingWorld")] public raRef<CResource> StreamingWorld { get; set; }
		[Ordinal(3)]  [RED("worldName")] public CString WorldName { get; set; }
		[Ordinal(4)]  [RED("spawnPointTags")] public redTagList SpawnPointTags { get; set; }

		public gsmGameDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
