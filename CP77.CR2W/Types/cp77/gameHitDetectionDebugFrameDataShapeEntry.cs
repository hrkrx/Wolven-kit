using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitDetectionDebugFrameDataShapeEntry : CVariable
	{
		[Ordinal(0)] [RED("ansformWS")] public WorldTransform AnsformWS { get; set; }

		public gameHitDetectionDebugFrameDataShapeEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
