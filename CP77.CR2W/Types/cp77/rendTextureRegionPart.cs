using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendTextureRegionPart : ISerializable
	{
		[Ordinal(0)] [RED("innerRegion")] public Vector4 InnerRegion { get; set; }
		[Ordinal(1)] [RED("outerRegion")] public Vector4 OuterRegion { get; set; }

		public rendTextureRegionPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
