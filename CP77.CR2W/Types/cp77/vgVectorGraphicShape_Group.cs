using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Group : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] [RED("childShapes")] public CArray<CHandle<vgBaseVectorGraphicShape>> ChildShapes { get; set; }

		public vgVectorGraphicShape_Group(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
