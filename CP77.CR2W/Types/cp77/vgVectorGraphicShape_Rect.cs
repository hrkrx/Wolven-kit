using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Rect : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] [RED("mensions")] public Vector2 Mensions { get; set; }

		public vgVectorGraphicShape_Rect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
