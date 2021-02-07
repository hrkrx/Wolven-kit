using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerChangeAppearance_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)]  [RED("entityRef")] public gameEntityReference EntityRef { get; set; }
		[Ordinal(1)]  [RED("prefetchOnly")] public CBool PrefetchOnly { get; set; }
		[Ordinal(2)]  [RED("appearanceName")] public CName AppearanceName { get; set; }

		public questEntityManagerChangeAppearance_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
