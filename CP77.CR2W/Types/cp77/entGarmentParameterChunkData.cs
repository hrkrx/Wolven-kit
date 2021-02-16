using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entGarmentParameterChunkData : CVariable
	{
		[Ordinal(0)] [RED("morphOffsetScales")] public CArray<CUInt8> MorphOffsetScales { get; set; }
		[Ordinal(1)] [RED("visibleTriangleInds")] public CArray<CUInt16> VisibleTriangleInds { get; set; }

		public entGarmentParameterChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
