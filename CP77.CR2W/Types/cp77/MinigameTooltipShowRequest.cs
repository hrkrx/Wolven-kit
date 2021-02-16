using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinigameTooltipShowRequest : redEvent
	{
		[Ordinal(0)] [RED("data")] public CHandle<MessageTooltipData> Data { get; set; }

		public MinigameTooltipShowRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
