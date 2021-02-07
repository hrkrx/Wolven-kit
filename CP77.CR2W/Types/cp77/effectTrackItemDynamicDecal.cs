using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDynamicDecal : effectTrackItem
	{
		[Ordinal(0)]  [RED("material")] public rRef<IMaterial> Material { get; set; }
		[Ordinal(1)]  [RED("width")] public CFloat Width { get; set; }
		[Ordinal(2)]  [RED("height")] public CFloat Height { get; set; }
		[Ordinal(3)]  [RED("fadeInTime")] public CFloat FadeInTime { get; set; }
		[Ordinal(4)]  [RED("fadeOutTime")] public CFloat FadeOutTime { get; set; }
		[Ordinal(5)]  [RED("additionalRotation")] public CFloat AdditionalRotation { get; set; }
		[Ordinal(6)]  [RED("randomRotation")] public CBool RandomRotation { get; set; }

		public effectTrackItemDynamicDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
