using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStaticMarkerNode : worldSocketNode
	{
		[Ordinal(2)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)] [RED("tags")] public redTagList Tags { get; set; }
		[Ordinal(4)] [RED("data")] public CHandle<worldIMarker> Data { get; set; }

		public worldStaticMarkerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
