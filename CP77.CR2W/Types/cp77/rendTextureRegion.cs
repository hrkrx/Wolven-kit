using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendTextureRegion : ISerializable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("isStretch")] public CBool IsStretch { get; set; }
		[Ordinal(2)]  [RED("regionParts")] public CArray<rendTextureRegionPart> RegionParts { get; set; }

		public rendTextureRegion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
