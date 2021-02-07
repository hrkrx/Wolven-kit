using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VignetteAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("vignetteEnabled")] public CBool VignetteEnabled { get; set; }
		[Ordinal(1)]  [RED("vignetteRadius")] public CFloat VignetteRadius { get; set; }
		[Ordinal(2)]  [RED("vignetteExp")] public CFloat VignetteExp { get; set; }
		[Ordinal(3)]  [RED("vignetteColor")] public CColor VignetteColor { get; set; }

		public VignetteAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
