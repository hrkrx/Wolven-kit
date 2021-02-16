using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAmbientPaletteEntry : CVariable
	{
		[Ordinal(0)] [RED("brushCategory")] public CName BrushCategory { get; set; }

		public audioAmbientPaletteEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
