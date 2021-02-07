using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCommunityTemplate_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(0)]  [RED("spawnerReference")] public NodeRef SpawnerReference { get; set; }
		[Ordinal(1)]  [RED("communityEntryName")] public CName CommunityEntryName { get; set; }
		[Ordinal(2)]  [RED("communityEntryPhaseName")] public CName CommunityEntryPhaseName { get; set; }

		public questCommunityTemplate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
