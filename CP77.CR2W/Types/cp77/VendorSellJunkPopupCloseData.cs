using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorSellJunkPopupCloseData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("confirm")] public CBool Confirm { get; set; }
		[Ordinal(7)] [RED("items")] public CArray<wCHandle<gameItemData>> Items { get; set; }
		[Ordinal(8)] [RED("limitedItems")] public CArray<CHandle<VendorJunkSellItem>> LimitedItems { get; set; }

		public VendorSellJunkPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
