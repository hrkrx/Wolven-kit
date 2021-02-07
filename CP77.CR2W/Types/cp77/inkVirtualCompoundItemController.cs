using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkVirtualCompoundItemController : inkButtonController
	{
		[Ordinal(0)]  [RED("ToggledOff")] public inkVirtualCompoundItemControllerCallback ToggledOff { get; set; }
		[Ordinal(1)]  [RED("ToggledOn")] public inkVirtualCompoundItemControllerCallback ToggledOn { get; set; }
		[Ordinal(2)]  [RED("Selected")] public inkVirtualCompoundItemSelectControllerCallback Selected { get; set; }
		[Ordinal(3)]  [RED("Deselected")] public inkVirtualCompoundItemControllerCallback Deselected { get; set; }
		[Ordinal(4)]  [RED("Added")] public inkVirtualCompoundItemControllerCallback Added { get; set; }

		public inkVirtualCompoundItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
