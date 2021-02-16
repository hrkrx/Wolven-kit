using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CraftingNotification : GenericNotificationController
	{
		[Ordinal(12)] [RED("introAnimation")] public CHandle<inkanimProxy> IntroAnimation { get; set; }

		public CraftingNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
