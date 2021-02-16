using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workUnequipPropAction : workIWorkspotItemAction
	{
		[Ordinal(0)] [RED("itemId")] public CName ItemId { get; set; }

		public workUnequipPropAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
