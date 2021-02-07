using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinimapDataNode : worldNode
	{
		[Ordinal(0)]  [RED("encodedShapesRef")] public raRef<minimapEncodedShapes> EncodedShapesRef { get; set; }
		[Ordinal(1)]  [RED("localBounds")] public Box LocalBounds { get; set; }
		[Ordinal(2)]  [RED("allInteriorShapes")] public CBool AllInteriorShapes { get; set; }

		public MinimapDataNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
