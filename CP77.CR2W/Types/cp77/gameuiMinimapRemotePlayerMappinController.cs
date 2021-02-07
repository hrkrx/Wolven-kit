using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapRemotePlayerMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("rootWidget")] public inkWidgetReference RootWidget { get; set; }
		[Ordinal(1)]  [RED("shapeWidget")] public inkWidgetReference ShapeWidget { get; set; }
		[Ordinal(2)]  [RED("dataWidget")] public inkWidgetReference DataWidget { get; set; }

		public gameuiMinimapRemotePlayerMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
