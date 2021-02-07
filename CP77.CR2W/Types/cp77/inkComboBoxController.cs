using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkComboBoxController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("comboBoxObjectRef")] public inkWidgetReference ComboBoxObjectRef { get; set; }
		[Ordinal(1)]  [RED("ComboBoxVisibleChanged")] public inkComboBoxVisibleChangedCallback ComboBoxVisibleChanged { get; set; }

		public inkComboBoxController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
