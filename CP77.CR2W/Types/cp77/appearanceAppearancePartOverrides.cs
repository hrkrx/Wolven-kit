using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearancePartOverrides : CVariable
	{
		[Ordinal(0)]  [RED("partResource")] public raRef<entEntityTemplate> PartResource { get; set; }
		[Ordinal(1)]  [RED("componentsOverrides")] public CArray<appearancePartComponentOverrides> ComponentsOverrides { get; set; }

		public appearanceAppearancePartOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
