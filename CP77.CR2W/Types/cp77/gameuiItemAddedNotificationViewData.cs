using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiItemAddedNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(0)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)]  [RED("animation")] public CName Animation { get; set; }
		[Ordinal(2)]  [RED("itemRarity")] public CName ItemRarity { get; set; }

		public gameuiItemAddedNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
