using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentNode : worldNode
	{
		[Ordinal(2)] [RED("resource")] public raRef<worldTrafficPersistentResource> Resource { get; set; }

		public worldTrafficPersistentNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
