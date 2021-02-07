using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkDiscreteNavigationController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("shouldUpdateScrollController")] public CBool ShouldUpdateScrollController { get; set; }
		[Ordinal(1)]  [RED("isNavigalbe")] public CBool IsNavigalbe { get; set; }
		[Ordinal(2)]  [RED("supportsHoldInput")] public CBool SupportsHoldInput { get; set; }

		public inkDiscreteNavigationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
