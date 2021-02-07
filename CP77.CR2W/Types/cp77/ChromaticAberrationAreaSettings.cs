using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChromaticAberrationAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("chromaticAberrationEnabled")] public CBool ChromaticAberrationEnabled { get; set; }
		[Ordinal(1)]  [RED("chromaticAberrationMargin")] public CFloat ChromaticAberrationMargin { get; set; }
		[Ordinal(2)]  [RED("chromaticAberrationOffset")] public CFloat ChromaticAberrationOffset { get; set; }
		[Ordinal(3)]  [RED("chromaticAberrationExp")] public CFloat ChromaticAberrationExp { get; set; }
		[Ordinal(4)]  [RED("subpixelDispersal")] public CFloat SubpixelDispersal { get; set; }

		public ChromaticAberrationAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
