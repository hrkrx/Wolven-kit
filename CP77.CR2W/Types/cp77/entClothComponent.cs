using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entClothComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("mesh")] public rRef<CMesh> Mesh { get; set; }
		[Ordinal(9)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public entClothComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
