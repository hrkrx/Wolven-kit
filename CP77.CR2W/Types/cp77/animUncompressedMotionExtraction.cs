using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animUncompressedMotionExtraction : animIMotionExtraction
	{
		[Ordinal(0)]  [RED("frames")] public CArray<Vector4> Frames { get; set; }
		[Ordinal(1)]  [RED("duration")] public CFloat Duration { get; set; }

		public animUncompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
