using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkGenericSystemNotificationLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("titleTextWidget")] public inkTextWidgetReference TitleTextWidget { get; set; }
		[Ordinal(1)]  [RED("descriptionTextWidget")] public inkTextWidgetReference DescriptionTextWidget { get; set; }
		[Ordinal(2)]  [RED("additionalDataTextWidget")] public inkTextWidgetReference AdditionalDataTextWidget { get; set; }
		[Ordinal(3)]  [RED("introAnimationName")] public CName IntroAnimationName { get; set; }
		[Ordinal(4)]  [RED("outroAnimationName")] public CName OutroAnimationName { get; set; }
		[Ordinal(5)]  [RED("confirmButton")] public inkWidgetReference ConfirmButton { get; set; }
		[Ordinal(6)]  [RED("cancelButton")] public inkWidgetReference CancelButton { get; set; }

		public inkGenericSystemNotificationLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
