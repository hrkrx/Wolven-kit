using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EquipmentWidgets : CVariable
	{
		[Ordinal(0)] [RED("widgetArray")] public CArray<inkWidgetReference> WidgetArray { get; set; }

		public EquipmentWidgets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
