using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entClothComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("mesh")] public rRef<CMesh> Mesh { get; set; }

		public entClothComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
