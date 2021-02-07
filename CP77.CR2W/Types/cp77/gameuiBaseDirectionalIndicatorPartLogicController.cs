using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseDirectionalIndicatorPartLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("defaultForwardFovRange")] public CFloat DefaultForwardFovRange { get; set; }
		[Ordinal(1)]  [RED("adjustedForwardFovRange")] public CFloat AdjustedForwardFovRange { get; set; }

		public gameuiBaseDirectionalIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
