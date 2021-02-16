using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreview_ReadyToBeDisplayed : redEvent
	{
		[Ordinal(0)] [RED("isMale")] public CBool IsMale { get; set; }

		public gameuiPuppetPreview_ReadyToBeDisplayed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
