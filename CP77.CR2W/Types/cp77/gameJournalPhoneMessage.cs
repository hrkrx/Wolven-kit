using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalPhoneMessage : gameJournalEntry
	{
		[Ordinal(0)]  [RED("sender")] public CEnum<gameMessageSender> Sender { get; set; }
		[Ordinal(1)]  [RED("text")] public LocalizationString Text { get; set; }
		[Ordinal(2)]  [RED("imageId")] public TweakDBID ImageId { get; set; }
		[Ordinal(3)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(4)]  [RED("attachment")] public CHandle<gameJournalPath> Attachment { get; set; }

		public gameJournalPhoneMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
