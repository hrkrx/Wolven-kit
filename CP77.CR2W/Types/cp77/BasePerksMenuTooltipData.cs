using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BasePerksMenuTooltipData : ATooltipData
	{
		[Ordinal(0)] [RED("manager")] public CHandle<PlayerDevelopmentDataManager> Manager { get; set; }

		public BasePerksMenuTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
