using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficSyncPointDefinition : CVariable
	{
		[Ordinal(0)]  [RED("laneRefs")] public CArray<NodeRef> LaneRefs { get; set; }
		[Ordinal(1)]  [RED("lanePositions")] public CArray<CFloat> LanePositions { get; set; }
		[Ordinal(2)]  [RED("length")] public CFloat Length { get; set; }

		public worldTrafficSyncPointDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
