using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioKeyUiControlPairDictionaryItem : audioInlinedAudioMetadata
	{
		[Ordinal(1)] [RED("key")] public CName Key { get; set; }
		[Ordinal(2)] [RED("value")] public audioUiControl Value { get; set; }

		public audioKeyUiControlPairDictionaryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
